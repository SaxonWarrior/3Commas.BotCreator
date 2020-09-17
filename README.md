# 3Commas.BotCreator

This unofficial tool makes it possible to create several simple DCA bots at once.

**Note that only this use case is covered:**

I needed something that would allow me to create multiple simple DCA bots with the same quote currency. It will automatically find the next base currency ordered by Volume descending.
If short bots are created, the tool can buy base coins for you directly on your exchange (if desired).



---

## Technical description

The implementation is based on .Net Framework. I actually wanted to create it with .Net Core, but the View Designer isn't really ready for production yet. I will probably upgrade to .NET 5 in November.
Therefore I created the tool more or less quick & dirty because I needed this functionality quickly. Time was money in this case :)

Implementation is build upon the CryptoExchange.Net, 3Commas.Net, Binance.Net and Huobi.Net libraries. Thanks for the brilliant work!

The only use cases available are the ones I needed for myself. But if you need something, [let me know](https://github.com/MarcDrexler/3Commas.BotCreator/issues).

Also if you think something is broken or have any questions, please open an [Issue](https://github.com/MarcDrexler/3Commas.BotCreator/issues).

## Features

- Add as many bots you want
- Uses pairs at the highest volume first
- Skip bot creation for existing pair + strategy (if desired).
    - This way you can create 10 Bots, and another day the next 10 Bots without having to worry about duplicates.
- Specify your own name schema. There are existing placeholders for Strategy and Pair.
- Signals currently available: Manual, Nonstop, TradingView, RSI
- Buys tokens for your new Short bots via market buy order (Binance & Huobi only)

### Excluded Pairs

All pairs that end with UP, DOWN, BEAR, BULL and are skipped.
Also EUR Pairs.

The blacklist is currently hard coded and will be configurable in the future

## Screenshots

![Main Screen](https://github.com/MarcDrexler/3Commas.BotCreator/blob/master/screenshots/Mainscreen.png)

## Prerequisites

- .NET Framework 4.7.2 (which already might be installed on your Windows machine)
- 3Commas API key and secret
- Exchange API key and secret (Binance or Huobi)

Note: API Keys will never be stored on your machine. They are only available in memory and must be provisioned again the next time the application is started.

### Why API Keys for my Exchange?

The app will find suitable pairs for you. It simply queries your exchange for pairs and ranks them in descending order of volume.
If you want to create short bots and don't have tokens for the new pairs, tokens are automatically bought for you (if you choose to).

## Installer

I use MS ClickOnce for installation and updates.

An installer with the current version is hosted [here](https://marcdrexler.blob.core.windows.net/botcreator/BotCreator.application)

Updates are automatically checked for each start.

Because the package is not signed with a public certificate, you might see some security warnings when installing and starting the app if you are using Windows 7 or later.

## Support

I develop and maintain this package on my own for free in my spare time.
Donations are greatly appreciated and a motivation to keep improving.

XMR: 89rmrxDAGAWWhSZXhnNf335qYfyXz4vQsNAM1VFSg6Y7Tve9BGF9pwte9ps61E9FY76r4onhWw7e19eu7fM8BARQMRHNBt7

or

<a href="https://www.buymeacoffee.com/marcdrexler" target="_blank"><img width="136" height="40" src="https://cdn.buymeacoffee.com/buttons/v2/default-orange.png" alt="Buy Me A Coffee" style="height: 40px !important;width: 136px !important;" ></a>



