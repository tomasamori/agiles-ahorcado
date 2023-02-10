Feature: Hangman
	In order to play the game
	As a player
	I want to guess a word and know if I won or not

@partida
Scenario: Lose the game letter by letter
	Given The word to guess 'AGILES'
	When I enter X as the LetraIngresada seven times
	Then I should be told that I lost the game

@partida
Scenario: Win the game letter by letter
	Given The word to guess 'AGILES'
	When I entered A as the LetraIngresada
	And I entered G as the LetraIngresada
	And I entered I as the LetraIngresada
	And I entered L as the LetraIngresada
	And I entered E as the LetraIngresada
	And I entered S as the LetraIngresada
	Then I should be told that I won the game

@partida
Scenario: Win the game entering a word
	Given The word to guess 'AGILES'
	When I entered 'AGILES' as the PalabraIngresada
	Then I should be told that I won the game