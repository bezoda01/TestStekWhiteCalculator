Feature: FirstFeatureInputingTheNumber

Scenario: Inputing the number
	Given Main form is open

	When I click on numbers 1
	Then the result of math should be 1

	When I click on View menu bar
	Then I select option Scientific from View menu bar