// Placed at the top of BlorfGameManager.Update()

this.RoundCardText.enableWordWrapping = false;		
this.RoundCardText.text = "Cards put down: ";
for (int i = 0; i < this.LastRound.Count; i++)
{
	string card;
	switch (this.LastRound[i])
	{
	case 1:
		card = "king";
		break;
	case 2:
		card = "queen";
		break;
	case 3:
		card = "ace";
		break;
	case 4:
		card = "joker";
		break;
	default:
		card = "devil";
		break;
	}
	TextMeshProUGUI roundCardText = this.RoundCardText;
	roundCardText.text += card;
	if (i != this.LastRound.Count - 1)
	{
		TextMeshProUGUI roundCardText2 = this.RoundCardText;
		roundCardText2.text += ", ";
	}
}