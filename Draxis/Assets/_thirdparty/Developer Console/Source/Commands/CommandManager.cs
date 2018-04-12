
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

using System.Collections.Generic;

using UnityEngine;

class CommandManager : MonoBehaviour {
    public static Dictionary< string , Command > cmds = new Dictionary< string , Command >();
    public static List< Command >       cmdClasses    = new List< Command >();

    //------------------------------------------------------------------------------------------------
    // Purpose : Unity's callback function that will run at scene start.
    //------------------------------------------------------------------------------------------------
    private void Start() {
        CreateCommandInstance();
        RegisterCommand();
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Used for creating instances of command classes.
    //------------------------------------------------------------------------------------------------
    private void CreateCommandInstance() {
        Clear clearCmd = new Clear();
        Close closeCmd = new Close();
    }

    //------------------------------------------------------------------------------------------------
    // Purpose : Use this function to create/register commands.
    //           cmds.Add( name of command as string , class of command );
    //------------------------------------------------------------------------------------------------
    private void RegisterCommand() {
        cmds.Add( ".clear" , cmdClasses[ 0 ] );
        cmds.Add( ".close" , cmdClasses[ 1 ] );
    }
}