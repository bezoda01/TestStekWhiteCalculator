Feature: SecondFeatureSummingTwoNumbers

Scenario Outline: Summing two numbers
	Given Main form is open

	When I click on View menu bar
	Then I select option <Orientation> from View menu bar

	When I click on numbers 1 2
	Then I click on Plus
	Then I click on numbers 9 9 9
	When I click on equals
	Then I add result to memory
	When I click on numbers 1 9
	Then I click on Plus
	Then I get saved result
	When I click on equals
	Then the result of math should be 1030

Examples:
	| Orientation |
	| Standard    |
	| Scientific  |