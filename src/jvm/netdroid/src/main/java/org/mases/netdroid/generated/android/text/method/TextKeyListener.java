/*
 *  Copyright 2024 MASES s.r.l.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  Refer to LICENSE for more information.
 */

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*/

package org.mases.netdroid.generated.android.text.method;

public final class TextKeyListener extends org.mases.jcobridge.JCListener implements android.text.SpanWatcher {
    public TextKeyListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean backspace(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        raiseEvent("backspace", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean forwardDelete(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        raiseEvent("forwardDelete", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        raiseEvent("onKeyDown", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) {
        raiseEvent("onKeyOther", arg0, arg1, arg2); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        raiseEvent("onKeyUp", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public int getInputType() {
        raiseEvent("getInputType"); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public long clearMetaKeyState(long arg0, int arg1) {
        raiseEvent("clearMetaKeyState", arg0, arg1); Object retVal = getReturnData(); return (long)retVal;
    }
    //@Override
    public void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) {
        raiseEvent("clearMetaKeyState3", arg0, arg1, arg2);
    }
    //@Override
    public void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) {
        raiseEvent("onSpanAdded", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) {
        raiseEvent("onSpanChanged", arg0, arg1, arg2, arg3, arg4, arg5);
    }
    //@Override
    public void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) {
        raiseEvent("onSpanRemoved", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void release() {
        raiseEvent("release");
    }

}