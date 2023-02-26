Feature: Select test project to scan

As a TDD practioner
I would like to be configure the target for TDD loop to scan
So that I could choose freely the tests project path

Scenario: Configure a target tests project for scans using existing project
When I input an existing tests project file as a target for scans
Then it should be saved the next time I open configuration