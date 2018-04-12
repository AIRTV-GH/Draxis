
/*
 *  MIT License
 *
 *  Copyright (c) 2018 Ismail Ozsaygi
 *
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all
 *  copies or substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.
 */

using System;

using UnityEngine;
using UnityEngine.UI;

[ Serializable ]
enum ActivityStates {
    STATE_OPEN,
    STATE_CLOSE,
}

class DeveloperConsole : MonoBehaviour {
    [ Space ]

    [ Header( "Console Properties" ) ]
    public ActivityStates currentState;
    public InputField     commandInputField;

    public static Text    executedCommandsList;

    //------------------------------------------------------------------------------------------------
    // Purpose : Unity's callback function that will run before Start()
    //------------------------------------------------------------------------------------------------
    private void Awake() {
        Initialization();
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Load & set the properties.
    //------------------------------------------------------------------------------------------------
    private void Initialization() {
        executedCommandsList = GameObject.Find( "Executed Commands List" ).GetComponent< Text >();
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Toggles the state of console.
    //           Call this from button click event.
    //------------------------------------------------------------------------------------------------
    public void ToggleState() {
        switch( currentState ) {

            case ActivityStates.STATE_OPEN:

                currentState = ActivityStates.STATE_CLOSE;
                this.gameObject.SetActive( false );

            break;

            case ActivityStates.STATE_CLOSE:

                this.gameObject.SetActive( true );
                currentState = ActivityStates.STATE_OPEN;

            break;
        }
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Enable developer to print message to console from other files.
    //           Just a simple function call can do the trick.
    //           DeveloperConsole.Log( yourStringMessageHere );
    //------------------------------------------------------------------------------------------------
    public static void Log( string pMsg ) {
        executedCommandsList.text += pMsg;
        executedCommandsList.text += Environment.NewLine;
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Overloaded version of Log function.
    //           You can set the color of text with 2nd parameter.
    //------------------------------------------------------------------------------------------------
    public static void Log( string pMsg , Color pMsgClr ) {
        ColorUtility.ToHtmlStringRGBA( pMsgClr );
        string msgclr              = string.Format( "<color=#{0}>{1}</color>" , ColorUtility.ToHtmlStringRGBA( pMsgClr ) , pMsg );
        executedCommandsList.text += msgclr;
        executedCommandsList.text += Environment.NewLine;
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Displays executed command on list.
    //           Call this from Input Field's "end edit" event.
    //------------------------------------------------------------------------------------------------
    public void DisplayCommand() {
        executedCommandsList.text += commandInputField.text;
        executedCommandsList.text += Environment.NewLine;
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Execute the given command if it is on cmd list.
    //           Call from Input Field's "end edit" event.
    //           Call before "ClearField();" function.
    //------------------------------------------------------------------------------------------------
    public void ExecuteCommand() {
        if( CommandManager.cmds.ContainsKey( commandInputField.text ) ) {
            CommandManager.cmds[ commandInputField.text ].Action();
            Log( "Command : " + commandInputField.text + " executed successfully " , Color.green );
        }
        else
            Log( "Failed to execute command : " + commandInputField.text , Color.red );
    }

    ///------------------------------------------------------------------------------------------------
    // Purpose : Clears the text of input field.
    ///------------------------------------------------------------------------------------------------
    public void ClearField() {
        commandInputField.text = String.Empty;
    }
}