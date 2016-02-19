#pragma strict

var Obj : GameObject;

function Start () {

Obj.SetActive(false);

}

function OnTriggerEnter () { Obj.SetActive (true); }

function OnTriggerExit () { Obj.SetActive(false); }