#include "stdafx.h"
#include <iostream>
using namespace std;
#include <string>

//Declares global variables, which is just "option"
string option;

// Function that will covert metres to feet
int mtoft()
{//Local Variables
	double metres;
	double feet;

	cout << "Enter how many metres you want to convert \n";
	cin >> metres;

	//1 metre = 3.28 Feet

	feet = metres * 3.28084;
	cout << metres << " Metres = " << feet << " Feet" "\n";
	return 0;

}

//function that will convert cm to inch
int cmtoinch()
{
	//Local variables

	double inches;
	double cm;
	cout << "Enter how many centimetres you want to convert \n";
	cin >> cm;
	inches = cm * 0.393701;

	//1cm = 0.393 inches
	cout << cm << " cm = " << inches << " inches" "\n";
	return 0;

}



int menu()
{ //This will be outputed every time the user returns to the menu
	cout << "Enter a number between 1 and 3" "\n";
	cout << "1) to convert Centimetres into Inches" "\n";
	cout << "2) to convert Metres into Feet""\n";
	cout << "3) to exit from this program" "\n";

	cin >> option;

	//If the user enters a value that is not 1, 2 or 3 they will get an error


	if (option != "1" && option != "2" && option != "3")
	{
		cout << "You entered " + option + " thats not 1, 2 or 3 is it... \n" + "Try again \n";
		menu();
	}

		// the above if statement would cause the program to crash if a non numeric value was entered. So i made it a string and it now needs to be numeric again for the switch.

		int value = atoi(option.c_str());

		switch (value)
		{
		case 1:
			cmtoinch(); //carrys out the cm to inch function
			cout << "\n";
			menu(); //returns the user to the menu
			break;
		case 2:
			mtoft(); // carrys out the metres to feet function
			cout << " \n";
			menu(); //returns the user to the menu	
			break;

		case 3:
			cout << "Goodbye! \n";
			return 0; //Ends the program 

			break;

		}

	}


void main()
{
	menu(); // When the main function runs it will immediatly run the menu function


}


