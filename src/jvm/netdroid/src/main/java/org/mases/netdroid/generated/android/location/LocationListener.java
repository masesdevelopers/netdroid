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

package org.mases.netdroid.generated.android.location;

public final class LocationListener implements org.mases.jcobridge.IJCListener, android.location.LocationListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public LocationListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void onLocationChanged(android.location.Location arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onLocationChanged", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onFlushComplete(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onFlushComplete", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.location.LocationListener.super.onFlushComplete(arg0);
    }
    //@Override
    public void onFlushCompleteDefault(int arg0) {
        android.location.LocationListener.super.onFlushComplete(arg0);
    }
    //@Override
    public void onLocationChanged(java.util.List arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onLocationChanged1", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.location.LocationListener.super.onLocationChanged(arg0);
    }
    //@Override
    public void onLocationChangedDefault(java.util.List arg0) {
        android.location.LocationListener.super.onLocationChanged(arg0);
    }
    //@Override
    public void onProviderDisabled(java.lang.String arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProviderDisabled", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.location.LocationListener.super.onProviderDisabled(arg0);
    }
    //@Override
    public void onProviderDisabledDefault(java.lang.String arg0) {
        android.location.LocationListener.super.onProviderDisabled(arg0);
    }
    //@Override
    public void onProviderEnabled(java.lang.String arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onProviderEnabled", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) android.location.LocationListener.super.onProviderEnabled(arg0);
    }
    //@Override
    public void onProviderEnabledDefault(java.lang.String arg0) {
        android.location.LocationListener.super.onProviderEnabled(arg0);
    }
    //@Override
    public void onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onStatusChanged", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) android.location.LocationListener.super.onStatusChanged(arg0, arg1, arg2);
    }
    //@Override
    public void onStatusChangedDefault(java.lang.String arg0, int arg1, android.os.Bundle arg2) {
        android.location.LocationListener.super.onStatusChanged(arg0, arg1, arg2);
    }

}