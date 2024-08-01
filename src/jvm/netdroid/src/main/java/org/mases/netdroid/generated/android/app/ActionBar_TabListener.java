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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*/

package org.mases.netdroid.generated.android.app;

public final class ActionBar_TabListener extends org.mases.jcobridge.JCListener implements android.app.ActionBar.TabListener {
    public ActionBar_TabListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onTabReselected(android.app.ActionBar.Tab arg0, android.app.FragmentTransaction arg1) {
        raiseEvent("onTabReselected", arg0, arg1);
    }
    //@Override
    public void onTabSelected(android.app.ActionBar.Tab arg0, android.app.FragmentTransaction arg1) {
        raiseEvent("onTabSelected", arg0, arg1);
    }
    //@Override
    public void onTabUnselected(android.app.ActionBar.Tab arg0, android.app.FragmentTransaction arg1) {
        raiseEvent("onTabUnselected", arg0, arg1);
    }

}