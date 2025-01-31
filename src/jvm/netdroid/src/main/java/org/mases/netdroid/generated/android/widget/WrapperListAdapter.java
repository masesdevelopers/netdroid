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

package org.mases.netdroid.generated.android.widget;

public final class WrapperListAdapter implements org.mases.jcobridge.IJCListener, android.widget.WrapperListAdapter {
    final org.mases.jcobridge.JCListener _internalListener;

    public WrapperListAdapter(String key) throws org.mases.jcobridge.JCNativeException {
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
    public android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getView", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public android.widget.ListAdapter getWrappedAdapter() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getWrappedAdapter", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (android.widget.ListAdapter)retVal;
    }
    //@Override
    public boolean hasStableIds() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("hasStableIds", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEmpty() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("isEmpty", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean areAllItemsEnabled() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("areAllItemsEnabled", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEnabled(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("isEnabled", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public int getCount() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getCount", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public int getItemViewType(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItemViewType", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public int getViewTypeCount() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getViewTypeCount", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public java.lang.Object getItem(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItem", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public long getItemId(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItemId", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (long)retVal;
    }
    //@Override
    public void registerDataSetObserver(android.database.DataSetObserver arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("registerDataSetObserver", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void unregisterDataSetObserver(android.database.DataSetObserver arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("unregisterDataSetObserver", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public java.lang.CharSequence[] getAutofillOptions() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getAutofillOptions", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = android.widget.WrapperListAdapter.super.getAutofillOptions(); else retVal = eventDataExchange.getReturnData(); return (java.lang.CharSequence[])retVal;
    }
    //@Override
    public java.lang.CharSequence[] getAutofillOptionsDefault() {
        return android.widget.WrapperListAdapter.super.getAutofillOptions();
    }

}