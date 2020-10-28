Feature: CheckNewsTitles
	As a user of BBC site
	I want to check news articles
	So that I can see relevant news

@headline_atricle_title
Scenario: Check the headline article title
	Given User is on the BBC Home page 'https://www.bbc.com/'
	When User goes to the News page
	Then the headline article title should contain 'Trump picks Amy Coney Barrett for Supreme Court'

@secondary_articles_titles
Scenario: Check the secondary articles titles
	Given User is on the BBC Home page 'https://www.bbc.com/'
	When User goes to the News page
	Then the secondary articles titles should contain names
	| Names                                             |
	| Madrid at ‘serious risk’ without virus lockdown   |
	| Stabbings suspect 'was targeting Charlie Hebdo'   |
	| Lebanon rifts sink efforts to form new government |
	| Bollywood star questioned in India drugs case     |
	| Sparks fly during police chase                    |

@headline_category_article
Scenario: Check the first article in the category of headline article
	Given User is on the BBC Home page 'https://www.bbc.com/'
	When User goes to the News page
	And User searches headline article category name through the search input field
	Then the first article title on the Search page should contain 'Woman arrested at US-Canada border for poison mailed to White House'