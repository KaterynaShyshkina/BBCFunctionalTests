Feature: CheckFootballScores
	As a user of BBC site
	I want to see the result of football championship
	So that to verify the actual score

@mytag
Scenario Outline: Check football teams score
	Given User is on the BBC Home page 'https://www.bbc.com/'
	When User goes to the Football Scores And Fixtures Page
	And searches <home team> and <guest team> that have played <year-month> in <championship>
	Then the specific score (<home team points> : <guest team points>) is displayed
	When User clicks on <home team> or <guest team>
	Then the same score (<home team points> : <guest team points>) is displayed at the center of the screen
	Examples: 
	| championship          | year-month | home team          | guest team      | home team points | guest team points |
	| Scottish Championship | 2020-02    | Queen of the South | Greenock Morton | 0                | 4                 |
	| Italian Coppa Italia  | 2020-06    | Napoli             | Juventus        | 0                | 0                 |
	| Inter Milan           | 2020-07    | Inter Milan        | Bologna         | 1                | 2                 |
	| Scottish Championship | 2020-02    | Alloa Athletic     | Ayr United      | 0                | 2                 |
	| Italian Coppa Italia  | 2020-06    | Napoli             | Inter Milan     | 1                | 1                 |
