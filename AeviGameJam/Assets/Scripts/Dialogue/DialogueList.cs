using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueList : MonoBehaviour {

    public List<List<string>> listOfPlayerToGoblin = new List<List<string>>();
    public List<List<string>> listOfGoblinToPlayer = new List<List<string>>();
    public List<List<string>> listOfGoblinToGoblin = new List<List<string>>();
    public List<List<string>> listOfCheckpoint = new List<List<string>>();

    private void Start()
    {

        List<string> playerToGoblin1 = new List<string> {
        "Hey, qué tal?" };

        List<string> playerToGoblin2 = new List<string> {
        "Ugh, que asco..." };

        List<string> playerToGoblin3 = new List<string> { 
        "Mira! Un goblin" };

        listOfPlayerToGoblin.Add(playerToGoblin1);
        listOfPlayerToGoblin.Add(playerToGoblin2);
        listOfPlayerToGoblin.Add(playerToGoblin3);


        List<string> goblinToPlayer1 = new List<string> {
        "Uuhhhhh, me gusta tu ropa, donde la conseguiste?"};

        List<string> goblinToPlayer2 = new List<string> {
        "ega ega ega todo está en mega"};

        List<string> goblinToPlayer3 = new List<string> {
        "Taringa" };

        List<string> goblinToPlayer4 = new List<string> {
        "Desactiva el adblock que si no le podemos robar"};


        listOfGoblinToPlayer.Add(goblinToPlayer1);
        listOfGoblinToPlayer.Add(goblinToPlayer2);
        listOfGoblinToPlayer.Add(goblinToPlayer3);
        listOfGoblinToPlayer.Add(goblinToPlayer4);

        List<string> goblinToGoblin1 = new List<string> {
        "Uuhhhhh, me gusta tu ropa, donde la conseguiste?" };

        List<string> goblinToGoblin2 = new List<string> {
        "¿Has visto al nueva armadura del jugador?"};

        List<string> goblinToGoblin3 = new List<string> {
        "Me descargué esto en goblintorrent.com"};

        List<string> goblinToGoblin4 = new List<string> {
        "Desactiva el adblock que si no le podemos robar"};

        listOfGoblinToGoblin.Add(goblinToGoblin1);
        listOfGoblinToGoblin.Add(goblinToGoblin2);
        listOfGoblinToGoblin.Add(goblinToGoblin3);
        listOfGoblinToGoblin.Add(goblinToGoblin4);

        List<string> checkpointy = new List<string> {
        "Soy un punto de guardado, si me visitas, te recordaré"};

        listOfCheckpoint.Add(checkpointy);
    }

    





}
