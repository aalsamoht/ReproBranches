# ReproBranches
A collection of minimal bug reproduction cases, organized by branches.

## App
The bug cannot be reproduced on Android.

The bug can be reproduced on iOS with an iPhone 13 and iPhone 15 Pro running iOS 26.4.2, but not on an iPhone 7 running iOS 15.8.7.

The bug can be reproduced on both net9.0-ios and net10.0-ios.

### Reproducing the bug (Home tab)

* On the *Home* tab, press the *Go to child page* button
* Use the Shell back navigation button to go back
* Rapidly and repeatedly alternate between the *Go to child page* button and the Shell back button — place one finger on each and tap as fast as possible
* After several rapid repetitions, the page goes blank

### Not reproducible (Other tab)

On the *Other* tab, the *Go to child page* button navigates with `animate=false`. The blank page issue cannot be reproduced using this tab.
