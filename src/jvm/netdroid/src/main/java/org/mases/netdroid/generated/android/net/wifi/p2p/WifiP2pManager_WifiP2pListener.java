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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*/

package org.mases.netdroid.generated.android.net.wifi.p2p;

public final class WifiP2pManager_WifiP2pListener implements org.mases.jcobridge.IJCListener, android.net.wifi.p2p.WifiP2pManager.WifiP2pListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public WifiP2pManager_WifiP2pListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void onDeviceConfigurationChanged(android.net.wifi.p2p.WifiP2pDevice arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onDeviceConfigurationChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onDeviceConfigurationChanged(arg0);
    }
    //@Override
    public void onDeviceConfigurationChangedDefault(android.net.wifi.p2p.WifiP2pDevice arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onDeviceConfigurationChanged(arg0);
    }
    //@Override
    public void onDiscoveryStateChanged(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onDiscoveryStateChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onDiscoveryStateChanged(arg0);
    }
    //@Override
    public void onDiscoveryStateChangedDefault(int arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onDiscoveryStateChanged(arg0);
    }
    //@Override
    public void onFrequencyChanged(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onFrequencyChanged", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onFrequencyChanged(arg0, arg1);
    }
    //@Override
    public void onFrequencyChangedDefault(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onFrequencyChanged(arg0, arg1);
    }
    //@Override
    public void onGroupCreated(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGroupCreated", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreated(arg0, arg1);
    }
    //@Override
    public void onGroupCreatedDefault(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreated(arg0, arg1);
    }
    //@Override
    public void onGroupCreating() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGroupCreating", eventDataExchange); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreating();
    }
    //@Override
    public void onGroupCreatingDefault() {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreating();
    }
    //@Override
    public void onGroupCreationFailed(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGroupCreationFailed", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreationFailed(arg0);
    }
    //@Override
    public void onGroupCreationFailedDefault(int arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupCreationFailed(arg0);
    }
    //@Override
    public void onGroupNegotiationRejectedByUser() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGroupNegotiationRejectedByUser", eventDataExchange); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupNegotiationRejectedByUser();
    }
    //@Override
    public void onGroupNegotiationRejectedByUserDefault() {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupNegotiationRejectedByUser();
    }
    //@Override
    public void onGroupRemoved() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onGroupRemoved", eventDataExchange); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupRemoved();
    }
    //@Override
    public void onGroupRemovedDefault() {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onGroupRemoved();
    }
    //@Override
    public void onListenStateChanged(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onListenStateChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onListenStateChanged(arg0);
    }
    //@Override
    public void onListenStateChangedDefault(int arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onListenStateChanged(arg0);
    }
    //@Override
    public void onP2pStateChanged(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onP2pStateChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onP2pStateChanged(arg0);
    }
    //@Override
    public void onP2pStateChangedDefault(int arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onP2pStateChanged(arg0);
    }
    //@Override
    public void onPeerClientDisconnected(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPeerClientDisconnected", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerClientDisconnected(arg0, arg1);
    }
    //@Override
    public void onPeerClientDisconnectedDefault(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerClientDisconnected(arg0, arg1);
    }
    //@Override
    public void onPeerClientJoined(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPeerClientJoined", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerClientJoined(arg0, arg1);
    }
    //@Override
    public void onPeerClientJoinedDefault(android.net.wifi.p2p.WifiP2pInfo arg0, android.net.wifi.p2p.WifiP2pGroup arg1) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerClientJoined(arg0, arg1);
    }
    //@Override
    public void onPeerListChanged(android.net.wifi.p2p.WifiP2pDeviceList arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPeerListChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerListChanged(arg0);
    }
    //@Override
    public void onPeerListChangedDefault(android.net.wifi.p2p.WifiP2pDeviceList arg0) {
        android.net.wifi.p2p.WifiP2pManager.WifiP2pListener.super.onPeerListChanged(arg0);
    }

}