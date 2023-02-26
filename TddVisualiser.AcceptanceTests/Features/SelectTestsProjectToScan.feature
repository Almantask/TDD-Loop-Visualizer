Feature: Select test project to scan

As a TDD practioner
I would like to be configure the target for TDD loop to scan
So that I could choose freely the tests project path

Scenario: Configure a target tests project for scans using existing project
Given I input an existing tests project file as a target for scans
When I click save
Then it should be set the next time I open configuration

@nicetohave
Scenario: Configure a target project appends target steps for build output in csproj if they are not already there
Given a test project doesn't have target steps for build output
When I click save
Then it should append target steps in the project

@nicetohave
Scenario: Configure a target project appends target steps for build output in csproj if they are already there
Given a test project has target steps for build output
When I click save
Then it should keep the project as-is
