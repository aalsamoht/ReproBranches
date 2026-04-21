# ReproBranches
A collection of minimal bug reproduction cases, organized by branches.

## App
The app works as expected on Android and iOS with `MauiShellColorsNet9.csproj` (9.0.22).
The app works as expected on iOS with `MauiShellColorsNet10.csproj` (10.0.51).
The app does not work as expected on Android with `MauiShellColorsNet10.csproj` (MAUI 10.0.51).

The app has two Tabs, *Home* and *Other*. Each tab has a child page with a list of colored squares
that is populated in `OnAppearing` to introduce a small delay and expose a Shell color timing bug.

Each child page sets distinct Shell colors (title color, foreground, background).

To reproduce:

* Build and run using `MauiShellColorsNet10.csproj`
* On the *Home* tab, click the *Go to child* button to navigate to the child page
* On the *Other* tab, click the *Go to child* button to navigate to the child page
* Switch between the tabs while the child pages are open

The Shell colors of the page being navigated *to* are applied before the navigation completes,
so the current page briefly shows the wrong Shell colors — the ones belonging to the destination page.
