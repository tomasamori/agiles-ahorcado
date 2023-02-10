Feature: Hangman
	In order to play the game
	As a player
	I want to guess a word and know if I won or not

@mytag
Scenario: Lose the game
	When I enter X as the typedLetter seven times
	Then I should be told that I lost