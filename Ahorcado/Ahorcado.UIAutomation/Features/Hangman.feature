Feature: Hangman
	In order to play the game
	As a player
	I want to guess a word and know if I won or not

@partida
Scenario: Lose the game letter by letter
	Given The word to guess 'AGILES'
	When I enter X as the LetraIngresada seven times
	Then I should be told that I lost