Feature: Property Search
	In order to find a property
	As a user
	I want do be able to search using my desired criteria

Background: 
	Given I am on the Propertyfinder app home screen

Scenario: Filtering the property results by number of bedrooms
	When I filer the results to show only "1" bedroom properties
	Then the reslut list should  only contain "1" bedroom properties

Scenario: Sortiing the result list by price "Price (high)"
	And I am viewing rental properties
	When I sort the result list by "Price (high)"
	Then the result list should be sorted by the highest price first