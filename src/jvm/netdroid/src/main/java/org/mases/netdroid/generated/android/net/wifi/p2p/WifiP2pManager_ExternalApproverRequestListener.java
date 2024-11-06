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

public final class WifiP2pManager_ExternalApproverRequestListener implements org.mases.jcobridge.IJCListener, android.net.wifi.p2p.WifiP2pManager.ExternalApproverRequestListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public WifiP2pManager_ExternalApproverRequestListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void onAttached(android.net.MacAddress arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onAttached", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onConnectionRequested(int arg0, android.net.wifi.p2p.WifiP2pConfig arg1, android.net.wifi.p2p.WifiP2pDevice arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onConnectionRequested", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onDetached(android.net.MacAddress arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onDetached", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onPinGenerated(android.net.MacAddress arg0, java.lang.String arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPinGenerated", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }

}