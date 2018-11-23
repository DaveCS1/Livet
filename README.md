# Livet, a MVVM Infrastructure for WPF
---

## �͂��߂���

�ȉ��� Visual Studio �g���@�\�𓱓�����ƃv���W�F�N�g�e���v���[�g��A�C�e���e���v���[�g��R�[�h�X�j�y�b�g���ǉ�����܂��B

[Livet �v���W�F�N�g�e���v���[�g�E�A�C�e���e���v���[�g�E�R�[�h�X�j�y�b�g�g���@�\](https://marketplace.visualstudio.com/items?itemName=okazuki.livet)

NuGet �ł̓������\�ł����A���̏ꍇ�̓e���v���[�g��X�j�y�b�g�͓�������܂���B�󋵂ɍ��킹�Ďg�������Ă��������B

- [LivetCask](https://www.nuget.org/packages/LivetCask/)
- [LivetExtensions](https://www.nuget.org/packages/LivetExtensions/)

## �g�p���@

��{�I�Ȏg�p���@�͉��L�u���O�L�����Q�Ƃ��Ă��������B

[Livet Project Home (Japanese)](http://ugaya40.hateblo.jp/entry/Livet)

�ǉ��Ƃ��� `lsprop` �R�[�h�X�j�y�b�g�ŉ��L�̂悤�ȒZ���v���p�e�B�̒�`����������܂��B

```cs
private string _name;
public string Name
{
	get => _name;
	set => RaisePropertyChangedIfSet(ref _name, value);
}
```

RaisePropertyChangedIfSet ���\�b�h�́A�������ɑ������̒l�������� PropertyChanged �C�x���g�𔭍s���� true ��Ԃ��܂��B
�l���ς���Ă��Ȃ��ꍇ�̓C�x���g�̔��s�͍s�킸 false ��Ԃ��܂��B

## �����{�����e�i���X���j

�ŐV�� Livet �̓T�|�[�g���񋟂���Ă��� .NET Framework ���^�[�Q�b�g�Ƃ��ă����e�i���X���s���\��ł��B

�@�\�g���Ȃǂ������ Pull Request �𑗂��Ă��������BPull Request �𑗂�ꍇ�́A�P�̃e�X�g���Z�b�g�ł��ăe�X�g���ʂ�悤�ɂ��Ă����Ă��������B
�Ȃ�ׂ��m�F���Ď�荞�ނ悤�ɂ������Ǝv���܂��B

GitHub �̒ʒm�ɋC�t���Ă��Ȃ��\��������̂ŁA�}���̏ꍇ�� Twitter �� @okazuki �܂Ń����V��������������ƑΉ��������Ȃ�\��������܂��B

## Licensing
---
[zlib/libpng](http://opensource.org/licenses/zlib-license.php)
