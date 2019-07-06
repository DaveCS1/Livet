﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Windows.Threading;
using Livet.Annotations;
using Livet.EventListeners.WeakEvents;

namespace Livet.Messaging
{
    public sealed class MessageListener : IDisposable,
        IEnumerable<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>
    {
        [NotNull]
        private readonly ConcurrentDictionary<string, ConcurrentBag<Action<InteractionMessage>>> _actionDictionary =
            new ConcurrentDictionary<string, ConcurrentBag<Action<InteractionMessage>>>();

        [NotNull] private readonly LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
            InteractionMessageRaisedEventArgs> _listener;

        [NotNull] private readonly WeakReference<InteractionMessenger> _source;
        [NotNull] private Dispatcher _dispatcher;

        private bool _disposed;

        public MessageListener([NotNull] InteractionMessenger messenger)
        {
            if (messenger == null) throw new ArgumentNullException(nameof(messenger));

            _dispatcher = Dispatcher.CurrentDispatcher;
            _source = new WeakReference<InteractionMessenger>(messenger);
            _listener =
                new LivetWeakEventListener<EventHandler<InteractionMessageRaisedEventArgs>,
                    InteractionMessageRaisedEventArgs>
                (
                    h => h,
                    h => messenger.Raised += h,
                    h => messenger.Raised -= h,
                    MessageReceived
                );
        }

        public MessageListener([NotNull] InteractionMessenger messenger, [CanBeNull] string messageKey,
            Action<InteractionMessage> action)
            : this(messenger)
        {
            if (messageKey == null) messageKey = string.Empty;

            RegisterAction(messageKey, action);
        }

        public MessageListener([NotNull] InteractionMessenger messenger, Action<InteractionMessage> action)
            : this(messenger, null, action)
        {
        }

        [NotNull]
        public Dispatcher Dispatcher
        {
            get { return _dispatcher; }
            set { _dispatcher = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        IEnumerator<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>
            IEnumerable<KeyValuePair<string, ConcurrentBag<Action<InteractionMessage>>>>.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _actionDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            ThrowExceptionIfDisposed();
            return _actionDictionary.GetEnumerator();
        }

        public void RegisterAction(Action<InteractionMessage> action)
        {
            ThrowExceptionIfDisposed();
            _actionDictionary.GetOrAdd(string.Empty, _ => new ConcurrentBag<Action<InteractionMessage>>()).Add(action);
        }

        public void RegisterAction(string messageKey, Action<InteractionMessage> action)
        {
            ThrowExceptionIfDisposed();
            _actionDictionary.GetOrAdd(messageKey, _ => new ConcurrentBag<Action<InteractionMessage>>()).Add(action);
        }

        private void MessageReceived(object sender, InteractionMessageRaisedEventArgs e)
        {
            if (_disposed) return;

            var message = e.Message;

            var cloneMessage = (InteractionMessage) message.Clone();

            cloneMessage.Freeze();

            DoActionOnDispatcher(() => { GetValue(e, cloneMessage); });

            var responsiveMessage = message as ResponsiveInteractionMessage;

            object response;
            if (responsiveMessage != null &&
                (response = ((ResponsiveInteractionMessage) cloneMessage).Response) != null)
                responsiveMessage.Response = response;
        }

        private void GetValue(InteractionMessageRaisedEventArgs e, InteractionMessage cloneMessage)
        {
            var result = _source.TryGetTarget(out _);

            if (!result) return;

            if (e.Message.MessageKey != null)
            {
                _actionDictionary.TryGetValue(e.Message.MessageKey, out var list);

                if (list != null)
                    foreach (var action in list)
                        action(cloneMessage);
            }

            _actionDictionary.TryGetValue(string.Empty, out var allList);
            if (allList != null)
                foreach (var action in allList)
                    action(cloneMessage);
        }

        private void DoActionOnDispatcher([NotNull] Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            if (Dispatcher.CheckAccess())
                action();
            else
                Dispatcher.Invoke(action);
        }

        public void Add(Action<InteractionMessage> action)
        {
            RegisterAction(action);
        }

        public void Add(string messageKey, Action<InteractionMessage> action)
        {
            RegisterAction(messageKey, action);
        }


        public void Add(string messageKey, [NotNull] params Action<InteractionMessage>[] actions)
        {
            if (actions == null) throw new ArgumentNullException(nameof(actions));

            foreach (var action in actions) RegisterAction(messageKey, action);
        }

        private void ThrowExceptionIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException("EventListener");
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing) _listener.Dispose();
            _disposed = true;
        }
    }
}