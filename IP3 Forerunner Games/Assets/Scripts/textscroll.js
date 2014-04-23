var letterPause = 0.1;
var fontSize  : int = 24;
var x = 200;
var y = 550;
var w = 750;
var h = 350;
var y2 = 1000;
var ytemp=550;
var word = ""; //set in the inspector
var word2 = ""; //set in the inspector
var word3 = ""; //set in the inspector
var currentWord = "";
  
//Text scrolls into the textbox in three sections
//Ater once section is complete text is erased and next section scrolls in
//Final section stays displayed
  
function Start ()
{
    TypeText (word);
}
    
function AddText(newText : String)
{
    word = newText;
    TypeText(word2);
}
     
  function TypeText (compareWord : String) 
 {
    for (var letter in word.ToCharArray()) 
    {
    	if (word != compareWord) break;
    		currentWord += letter;
    		yield WaitForSeconds (letterPause);
	}	
	compareWord = word2;
	currentWord = "";
	for (var letter in word2.ToCharArray()) 
    {
    	if (word2 != compareWord) break;
    		currentWord += letter;
    		yield WaitForSeconds (letterPause);
	}
	compareWord = word3;currentWord = "";
	for (var letter in word3.ToCharArray()) 
    {
    	if (word3 != compareWord) break;
    		currentWord += letter;
    		yield WaitForSeconds (letterPause);
	}
}
     
function OnGUI()
{
	GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
    GUI.Label(new Rect(x, y, w, h), currentWord);
    Clicked();
}


function Clicked ()
{
	if (Input.GetMouseButtonDown (0)) { // if left button pressed...
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			var hit : RaycastHit;

			if (Physics.Raycast (ray, hit))
			{
				if (hit.transform.name == "Right") 
				{
					y=y2;
				}
				if (hit.transform.name == "ShowMap") 
				{
					y=y2;
				}
				if (hit.transform.name == "HideMap") 
				{
					y=ytemp;
				}
				if (hit.transform.name == "ShowJournal") 
				{
					y=y2;
				}
				if (hit.transform.name == "HideJournal") 
				{
					y=ytemp;
				}
			}
		}
}
			