# Nerdlabs.Avalonia.Extension

An extension to AvaloniaUI providing custom or additional control(s)
to the core project. Currently containing ```MessageBox``` control based
on [MessageBoxSlim.Avalonia](https://github.com/SirJson/MessageBoxSlim.Avalonia)

### Changelog
- Centered the text of controls such as buttons.
- Changed the message containing control from ```TextBox``` to ```TextBlock```
  for a more MessageBox like feel.
- Added ```BorderlessMessageBox``` for other specific usage and set as the
  default MessageBox style when ```MessageBoxStyle.None``` is used.