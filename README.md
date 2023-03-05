# TDD-Loop-Visualizer

An extension for Visual Studio to visualize test run flow (red, green) 

## Use Cases

![Flowchart](docs/UseCases.png)

## The way it works?

![Use cases](docs/Flowchart.png)

## Setup

### 1. Setup build outcome

The extension relies on pre/post build events. Set it up for the test project you want.
Highly recommended that you add to gitignore the build-output.txt file.

Print in a "build-output.txt" "Fail" for pre event:

```
echo Fail > "$(ProjectDir)build-output.txt"
```

Print in a "build-output.txt" "Fail" for post event::

```
echo Success > "$(ProjectDir)build-output.txt"
```

If build failed - it will remain with the word "Fail".
If it succeeded - the word "Fail" will be overriden.

This can also be done by simply adding these 2 lines:

```xml
  <Target Name="PostBuild" AfterTargets="PostBuildEvent">
    <Exec Command="echo Success &gt; &quot;$(ProjectDir)build-output.txt&quot;" />
  </Target>

  <Target Name="PreBuild" BeforeTargets="PreBuildEvent">
    <Exec Command="echo Fail &gt; &quot;$(ProjectDir)build-output.txt&quot;" />
  </Target>
```

### 2. Setup code coverage

If you use the default template, for example for xUnit, it should be fine as-is as it comes with codecov setup.

## Running tests (appium)

Follow instructions [here](https://www.headspin.io/blog/testing-windows-desktop-apps-with-appium).

## Tips

To add new tests, you will need https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/

This provides a tool `inspect.exe` which can be used to inspect desktop apps just like html.