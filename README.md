# ReproBranches
A collection of minimal bug reproduction cases, organized by branches.

## App
The app works as expected on iOS.
The app works as expected on Android when using 8.0.100, 9.0.0, or 9.0.22.
The app does not work as expected on Android when using 9.0.30, 9.0.40, or 9.0.70.

The app has two Tabs, *Home* and *Other*.

* On the *Home* tab click the *Go to child* button
* Click the *Other* tab
* Click the *Home* tab, the Shell colors are no longer correct
* Click the *Other* tab and then click the *Go to child* button
* Click the *Home* tab, the Shell colors are are the same colors used by the *Other* tab child page.
* To continue testing. Leave one child page open, then navigate to the other. The page that was navigated to last will replace the Shell colors set in the previously opened child page.
