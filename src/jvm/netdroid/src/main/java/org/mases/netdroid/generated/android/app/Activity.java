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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*/

package org.mases.netdroid.generated.android.app;

public final class Activity extends android.app.Activity implements org.mases.jcobridge.IJCListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public Activity(String key) throws org.mases.jcobridge.JCNativeException {
        super();
        _internalListener = new org.mases.jcobridge.JCListener(key);
    }

    public synchronized void release() {
       _internalListener.release();
    }
    
    public synchronized void raiseEvent(String eventName) {
       _internalListener.raiseEvent(eventName);
    }
    
    public synchronized void raiseEvent(String eventName, Object e) {
       _internalListener.raiseEvent(eventName, e);
    }
    
    public synchronized void raiseEvent(String eventName, Object e, Object... objects) {
       _internalListener.raiseEvent(eventName, e, objects);
    }
    
    public Object getEventData() {
       return _internalListener.getEventData();
    }
    
    public boolean hasExtraData() {
       return _internalListener.hasExtraData();
    }
    
    public int extraDataLength() {
       return _internalListener.extraDataLength();
    }
    
    public Object[] extraData() {
       return _internalListener.extraData();
    }
    
    public Object getReturnData() {
       return _internalListener.getReturnData();
    }
    
    public void setReturnData(Object retData) {
       _internalListener.setReturnData(retData);
    }

    //@Override
    public android.net.Uri onProvideReferrer() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProvideReferrer", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onProvideReferrer(); else retVal = eventDataExchange.getReturnData(); return (android.net.Uri)retVal;
    }
    //@Override
    public android.view.ActionMode onWindowStartingActionMode(android.view.ActionMode.Callback arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onWindowStartingActionMode", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onWindowStartingActionMode(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (android.view.ActionMode)retVal;
    }
    //@Override
    public android.view.ActionMode onWindowStartingActionMode(android.view.ActionMode.Callback arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onWindowStartingActionMode1", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onWindowStartingActionMode(arg0); else retVal = eventDataExchange.getReturnData(); return (android.view.ActionMode)retVal;
    }
    //@Override
    public android.view.View onCreatePanelView(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreatePanelView", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreatePanelView(arg0); else retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public android.view.View onCreateView(android.view.View arg0, java.lang.String arg1, android.content.Context arg2, android.util.AttributeSet arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateView", eventDataExchange, arg0, arg1, arg2, arg3); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreateView(arg0, arg1, arg2, arg3); else retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateView3", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreateView(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public boolean onContextItemSelected(android.view.MenuItem arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onContextItemSelected", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onContextItemSelected(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onCreateOptionsMenu(android.view.Menu arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateOptionsMenu", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreateOptionsMenu(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onCreatePanelMenu(int arg0, android.view.Menu arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreatePanelMenu", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreatePanelMenu(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateThumbnail", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreateThumbnail(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onGenericMotionEvent(android.view.MotionEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGenericMotionEvent", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onGenericMotionEvent(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyDown(int arg0, android.view.KeyEvent arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyDown", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyDown(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyLongPress(int arg0, android.view.KeyEvent arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyLongPress", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyLongPress(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyMultiple", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyMultiple(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyShortcut(int arg0, android.view.KeyEvent arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyShortcut", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyShortcut(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyUp(int arg0, android.view.KeyEvent arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyUp", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyUp(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onMenuItemSelected(int arg0, android.view.MenuItem arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onMenuItemSelected", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onMenuItemSelected(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onMenuOpened(int arg0, android.view.Menu arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onMenuOpened", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onMenuOpened(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onNavigateUp() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onNavigateUp", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onNavigateUp(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onNavigateUpFromChild(android.app.Activity arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onNavigateUpFromChild", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onNavigateUpFromChild(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onOptionsItemSelected(android.view.MenuItem arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onOptionsItemSelected", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onOptionsItemSelected(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onPictureInPictureRequested() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPictureInPictureRequested", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onPictureInPictureRequested(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onPrepareOptionsMenu(android.view.Menu arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPrepareOptionsMenu", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onPrepareOptionsMenu(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPreparePanel", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onPreparePanel(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onSearchRequested() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onSearchRequested", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onSearchRequested(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onSearchRequested(android.view.SearchEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onSearchRequested1", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onSearchRequested(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onTouchEvent(android.view.MotionEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onTouchEvent", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onTouchEvent(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onTrackballEvent(android.view.MotionEvent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onTrackballEvent", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onTrackballEvent(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public void onPointerCaptureChanged(boolean arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPointerCaptureChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.app.Activity.super.onPointerCaptureChanged(arg0);
    }
    //@Override
    public void onPointerCaptureChangedDefault(boolean arg0) {
        android.app.Activity.super.onPointerCaptureChanged(arg0);
    }
    //@Override
    public java.lang.CharSequence onCreateDescription() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateDescription", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onCreateDescription(); else retVal = eventDataExchange.getReturnData(); return (java.lang.CharSequence)retVal;
    }
    //@Override
    public java.lang.Object onRetainNonConfigurationInstance() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRetainNonConfigurationInstance", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onRetainNonConfigurationInstance(); else retVal = eventDataExchange.getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public void onActionModeFinished(android.view.ActionMode arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onActionModeFinished", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onActionModeFinished(arg0);
    }
    //@Override
    public void onActionModeStarted(android.view.ActionMode arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onActionModeStarted", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onActionModeStarted(arg0);
    }
    //@Override
    public void onActivityReenter(int arg0, android.content.Intent arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onActivityReenter", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onActivityReenter(arg0, arg1);
    }
    //@Override
    public void onActivityResult(int arg0, int arg1, android.content.Intent arg2, android.app.ComponentCaller arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onActivityResult", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) super.onActivityResult(arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onAttachedToWindow() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onAttachedToWindow", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onAttachedToWindow();
    }
    //@Override
    public void onAttachFragment(android.app.Fragment arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onAttachFragment", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onAttachFragment(arg0);
    }
    //@Override
    public void onBackPressed() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onBackPressed", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onBackPressed();
    }
    //@Override
    public void onConfigurationChanged(android.content.res.Configuration arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onConfigurationChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onConfigurationChanged(arg0);
    }
    //@Override
    public void onContentChanged() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onContentChanged", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onContentChanged();
    }
    //@Override
    public void onContextMenuClosed(android.view.Menu arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onContextMenuClosed", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onContextMenuClosed(arg0);
    }
    //@Override
    public void onCreate(android.os.Bundle arg0, android.os.PersistableBundle arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreate", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onCreate(arg0, arg1);
    }
    //@Override
    public void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu.ContextMenuInfo arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateContextMenu", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.onCreateContextMenu(arg0, arg1, arg2);
    }
    //@Override
    public void onCreateNavigateUpTaskStack(android.app.TaskStackBuilder arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onCreateNavigateUpTaskStack", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onCreateNavigateUpTaskStack(arg0);
    }
    //@Override
    public void onDetachedFromWindow() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onDetachedFromWindow", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onDetachedFromWindow();
    }
    //@Override
    public void onEnterAnimationComplete() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onEnterAnimationComplete", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onEnterAnimationComplete();
    }
    //@Override
    public void onGetDirectActions(android.os.CancellationSignal arg0, java.util.function.Consumer arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGetDirectActions", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onGetDirectActions(arg0, arg1);
    }
    //@Override
    public void onLocalVoiceInteractionStarted() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onLocalVoiceInteractionStarted", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onLocalVoiceInteractionStarted();
    }
    //@Override
    public void onLocalVoiceInteractionStopped() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onLocalVoiceInteractionStopped", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onLocalVoiceInteractionStopped();
    }
    //@Override
    public void onLowMemory() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onLowMemory", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onLowMemory();
    }
    //@Override
    public void onMultiWindowModeChanged(boolean arg0, android.content.res.Configuration arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onMultiWindowModeChanged", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onMultiWindowModeChanged(arg0, arg1);
    }
    //@Override
    public void onMultiWindowModeChanged(boolean arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onMultiWindowModeChanged1", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onMultiWindowModeChanged(arg0);
    }
    //@Override
    public void onNewIntent(android.content.Intent arg0, android.app.ComponentCaller arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onNewIntent", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onNewIntent(arg0, arg1);
    }
    //@Override
    public void onOptionsMenuClosed(android.view.Menu arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onOptionsMenuClosed", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onOptionsMenuClosed(arg0);
    }
    //@Override
    public void onPanelClosed(int arg0, android.view.Menu arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPanelClosed", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onPanelClosed(arg0, arg1);
    }
    //@Override
    public void onPerformDirectAction(java.lang.String arg0, android.os.Bundle arg1, android.os.CancellationSignal arg2, java.util.function.Consumer arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPerformDirectAction", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) super.onPerformDirectAction(arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onPictureInPictureModeChanged(boolean arg0, android.content.res.Configuration arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPictureInPictureModeChanged", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onPictureInPictureModeChanged(arg0, arg1);
    }
    //@Override
    public void onPictureInPictureModeChanged(boolean arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPictureInPictureModeChanged1", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onPictureInPictureModeChanged(arg0);
    }
    //@Override
    public void onPictureInPictureUiStateChanged(android.app.PictureInPictureUiState arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPictureInPictureUiStateChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onPictureInPictureUiStateChanged(arg0);
    }
    //@Override
    public void onPostCreate(android.os.Bundle arg0, android.os.PersistableBundle arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPostCreate", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onPostCreate(arg0, arg1);
    }
    //@Override
    public void onPrepareNavigateUpTaskStack(android.app.TaskStackBuilder arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPrepareNavigateUpTaskStack", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onPrepareNavigateUpTaskStack(arg0);
    }
    //@Override
    public void onProvideAssistContent(android.app.assist.AssistContent arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProvideAssistContent", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onProvideAssistContent(arg0);
    }
    //@Override
    public void onProvideAssistData(android.os.Bundle arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProvideAssistData", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onProvideAssistData(arg0);
    }
    //@Override
    public void onProvideKeyboardShortcuts(java.util.List arg0, android.view.Menu arg1, int arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProvideKeyboardShortcuts", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.onProvideKeyboardShortcuts(arg0, arg1, arg2);
    }
    //@Override
    public void onRequestPermissionsResult(int arg0, java.lang.String[] arg1, int[] arg2, int arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRequestPermissionsResult", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) super.onRequestPermissionsResult(arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onRequestPermissionsResult(int arg0, java.lang.String[] arg1, int[] arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRequestPermissionsResult3", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.onRequestPermissionsResult(arg0, arg1, arg2);
    }
    //@Override
    public void onRestoreInstanceState(android.os.Bundle arg0, android.os.PersistableBundle arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRestoreInstanceState", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onRestoreInstanceState(arg0, arg1);
    }
    //@Override
    public void onSaveInstanceState(android.os.Bundle arg0, android.os.PersistableBundle arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onSaveInstanceState", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.onSaveInstanceState(arg0, arg1);
    }
    //@Override
    public void onStateNotSaved() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onStateNotSaved", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onStateNotSaved();
    }
    //@Override
    public void onTopResumedActivityChanged(boolean arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onTopResumedActivityChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onTopResumedActivityChanged(arg0);
    }
    //@Override
    public void onTrimMemory(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onTrimMemory", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onTrimMemory(arg0);
    }
    //@Override
    public void onUserInteraction() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onUserInteraction", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onUserInteraction();
    }
    //@Override
    public void onVisibleBehindCanceled() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onVisibleBehindCanceled", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.onVisibleBehindCanceled();
    }
    //@Override
    public void onWindowAttributesChanged(android.view.WindowManager.LayoutParams arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onWindowAttributesChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onWindowAttributesChanged(arg0);
    }
    //@Override
    public void onWindowFocusChanged(boolean arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onWindowFocusChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.onWindowFocusChanged(arg0);
    }

}