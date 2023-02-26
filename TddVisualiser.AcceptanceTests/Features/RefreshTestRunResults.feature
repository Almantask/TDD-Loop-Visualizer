Feature: Refresh test run results

As a TDD practitioner
I would like to scan the latest tests run outcome
So that it could be visualised as a red dot or a green dot

Scenario: Pressing a scan button appends a dot of expected color based on tests outcome
	Given the build has <build outcome>
	And tests have <tests outcome>
	When I click refresh button
	Then the <color> dot should be appeneded in tests run history
Examples:
	| build outcome | tests outcome | color |
	| failed        | N/A           | red   |
	| succeeded     | failed        | red   |
	| succeeded     | succeeded     | green |

Scenario: No build outcome - does nothing
	Given there is no build outcome
	When I click refresh button
	Then there should be no new dot appeneded in tests run history

Scenario: The same build outcome as before - does nothing
	Given there is build outcome of the same date time as the last scan
	When I click refresh button
	Then there should be no new dot appeneded in tests run history

Scenario: No code coverage - error stating to setup coverage
	Given there is no code coverage file
	When I click refresh button
	Then there should be an error prompted stating "No code coverage file setup. Are you missing code coverage setup?"

Scenario: No tests project configured - error stating to configure a target test project
	Given there is no tests project configured as target
	When I click refresh button
	Then there should be an error prompted stating "No target tests project found. Please configure it."