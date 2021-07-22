package com.company;

import java.util.Scanner;

public class RockPaperScissors {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Start By Entering A number");
        Player human = new Player("Human");
        Player computer = new Player("Computer");
        human.move = input.nextInt();
        System.out.println("ROCK IS 1 :: PAPER IS 2 :: SCISSORS 3");

        while (true) {
            if (human.move == -1) break;
            human.move = input.nextInt();
            makeComputerMove(computer);
            if (human.beats(computer)) {
                processWinner(human, computer);
            } else if (computer.beats(human)) {
                processWinner(computer, human);
            } else {
                System.out.println("HAH YOU BOTH THINK THE SAME! ");
                System.out.println("DRAW!");
            }
        }
        printFinalWinner(human, computer);
    }

    private static void makeComputerMove(Player computer) {
        computer.move = (int) (Math.random() * 3 + 1);
    }

    /**
     * Prints the final winner to the console with the scores
     * @param human The human player
     * @param computer The computer player
     */
    private static void printFinalWinner(Player human, Player computer) {
        System.out.println("\n\nThe Scores Are *DRUM NOISES* ");
        System.out.println("------------------------------\n".repeat(4));
        System.out.println("Human score : " + human.getScore());
        System.out.println("Computer score : " + computer.getScore());
        if (human.getScore() > computer.getScore()) {
            System.out.println("Human Race Is saved! We Won!");
        } else if (computer.getScore() > human.getScore()) {
            System.out.println("Sadly We Lost. Better Luck Next Time:)");
        } else {
            System.out.println("Scores are Tied");
        }
    }

    /**
     * Increments the score of the winner and prints the summary
     * @param winner The winning player
     * @param loser The player who lost
     */
    private static void processWinner(Player winner, Player loser) {
        winner.incrementScore();
        System.out.printf("%s Chose %s and %s Chose %s%n", winner.name, winner.moveString(), loser.name, loser.moveString());
    }
}

/**
 * Holds information about the player such as score, name, and move
 */
class Player {
    final static int ROCK = 1;
    final static int PAPER = 2;
    final static int SCISSORS = 3;
    String name;
    int move;
    private int score;

    public int getScore() {
        return this.score;
    }

    public void incrementScore() {
        this.score++;
    }

    public Player(String name) {
        this.name = name;
    }

    /**
     * Checks if the move of another player beats the current player
     * @param another The other player
     * @return Whether the other player's move beats this player's
     */
    public boolean beats(Player another) {
        return (this.move == ROCK && another.move == SCISSORS
                || (this.move == PAPER && another.move == ROCK)
                || (this.move == SCISSORS && another.move == PAPER));
    }

    /**
     * The move integer into a string such as "ROCK", "PAPER", or "SCISSORS"
     * @return The string interpretation of the move
     */
    public String moveString() {
        return this.move == 1 ? "ROCK" : this.move == 2 ? "PAPER" : "SCISSORS";
    }
}