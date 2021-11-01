# Nerdlabs.Avalonia.Extension

An extension to AvaloniaUI providing custom or additional control(s)
to the core project. Currently containing ```MessageBox``` control based
on [MessageBoxSlim.Avalonia](https://github.com/SirJson/MessageBoxSlim.Avalonia)

### Changelog
##### 1.0.0
- Centered the text of controls such as buttons.
- Changed the message containing control from ```TextBox``` to ```TextBlock```
  for a more MessageBox like feel.
- Message content is now wrap with the containing parent window instead of being
  chopped off.
- Added ```BorderlessMessageBox``` for other specific usage and set as the
  default MessageBox style when ```MessageBoxStyle.None``` is used.

##### 1.0.1
- Removed ```IsResizable``` which is equivalent to ```CanResize``` property as
  I find it a nuisance more than a feature.
- ```MessageBoxStyle.Icon``` is now more aligned with the ```MessageBoxStyle.Message```
  on presentation-level.
- ```MessageBox``` width now scales with ```MessageBoxStyle.MaxWidth``` so you have a single
  property that sets both.