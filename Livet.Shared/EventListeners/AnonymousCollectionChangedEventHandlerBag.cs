﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Livet.Annotations;

namespace Livet.EventListeners
{
    internal class AnonymousCollectionChangedEventHandlerBag : IEnumerable<
        KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
    {
        [NotNull] private readonly List<NotifyCollectionChangedEventHandler> _allHandlerList =
            new List<NotifyCollectionChangedEventHandler>();

        [NotNull] private readonly object _allHandlerListLockObject = new object();

        [NotNull] private readonly Dictionary<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>
            _handlerDictionary =
                new Dictionary<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>();

        [NotNull] private readonly object _handlerDictionaryLockObject = new object();

        [NotNull] private readonly Dictionary<List<NotifyCollectionChangedEventHandler>, object> _lockObjectDictionary =
            new Dictionary<List<NotifyCollectionChangedEventHandler>, object>();

        [NotNull] private readonly WeakReference<INotifyCollectionChanged> _source;

        internal AnonymousCollectionChangedEventHandlerBag(INotifyCollectionChanged source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            _source = new WeakReference<INotifyCollectionChanged>(source);
        }

        internal AnonymousCollectionChangedEventHandlerBag(INotifyCollectionChanged source,
            NotifyCollectionChangedEventHandler handler) : this(source)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            RegisterHandler(handler);
        }

        IEnumerator<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>
            IEnumerable<KeyValuePair<NotifyCollectionChangedAction, List<NotifyCollectionChangedEventHandler>>>.
            GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _handlerDictionary.GetEnumerator();
        }

        internal void RegisterHandler(NotifyCollectionChangedEventHandler handler)
        {
            lock (_allHandlerListLockObject)
            {
                _allHandlerList.Add(handler);
            }
        }

        internal void RegisterHandler(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            lock (_handlerDictionaryLockObject)
            {
                List<NotifyCollectionChangedEventHandler> bag;
                if (!_handlerDictionary.TryGetValue(action, out bag))
                {
                    bag = new List<NotifyCollectionChangedEventHandler>();
                    _lockObjectDictionary.Add(bag, new object());
                    _handlerDictionary[action] = bag;
                }

                bag.Add(handler);
            }
        }

        internal void ExecuteHandler([NotNull] NotifyCollectionChangedEventArgs e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            var result = _source.TryGetTarget(out var sourceResult);

            if (!result) return;

            List<NotifyCollectionChangedEventHandler> list;
            lock (_handlerDictionaryLockObject)
            {
                _handlerDictionary.TryGetValue(e.Action, out list);
            }

            if (list != null)
                lock (_lockObjectDictionary[list])
                {
                    foreach (var handler in list) handler(sourceResult, e);
                }

            lock (_allHandlerListLockObject)
            {
                if (_allHandlerList.Any())
                    foreach (var handler in _allHandlerList)
                        handler(sourceResult, e);
            }
        }

        internal void Add(NotifyCollectionChangedEventHandler handler)
        {
            RegisterHandler(handler);
        }

        internal void Add(NotifyCollectionChangedAction action, NotifyCollectionChangedEventHandler handler)
        {
            RegisterHandler(action, handler);
        }


        internal void Add(NotifyCollectionChangedAction action, [NotNull] params NotifyCollectionChangedEventHandler[] handlers)
        {
            if (handlers == null) throw new ArgumentNullException(nameof(handlers));

            foreach (var handler in handlers) RegisterHandler(action, handler);
        }
    }
}