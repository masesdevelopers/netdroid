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

package org.mases.netdroid.generated.android.widget;

public final class SimpleAdapter extends android.widget.SimpleAdapter implements org.mases.jcobridge.IJCListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public SimpleAdapter(String key) throws org.mases.jcobridge.JCNativeException {
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
    public android.content.res.Resources.Theme getDropDownViewTheme() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getDropDownViewTheme", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getDropDownViewTheme(); else retVal = eventDataExchange.getReturnData(); return (android.content.res.Resources.Theme)retVal;
    }
    //@Override
    public android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getDropDownView", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getDropDownView(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getView", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getView(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public android.widget.Filter getFilter() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getFilter", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getFilter(); else retVal = eventDataExchange.getReturnData(); return (android.widget.Filter)retVal;
    }
    //@Override
    public android.widget.SimpleAdapter.ViewBinder getViewBinder() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getViewBinder", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getViewBinder(); else retVal = eventDataExchange.getReturnData(); return (android.widget.SimpleAdapter.ViewBinder)retVal;
    }
    //@Override
    public boolean areAllItemsEnabled() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("areAllItemsEnabled", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.areAllItemsEnabled(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean hasStableIds() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("hasStableIds", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.hasStableIds(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEmpty() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("isEmpty", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.isEmpty(); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEnabled(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("isEnabled", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.isEnabled(arg0); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public int getItemViewType(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItemViewType", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getItemViewType(arg0); else retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public int getViewTypeCount() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getViewTypeCount", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getViewTypeCount(); else retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public int getCount() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getCount", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getCount(); else retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public java.lang.CharSequence[] getAutofillOptions() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getAutofillOptions", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getAutofillOptions(); else retVal = eventDataExchange.getReturnData(); return (java.lang.CharSequence[])retVal;
    }
    //@Override
    public java.lang.Object getItem(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItem", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getItem(arg0); else retVal = eventDataExchange.getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public long getItemId(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getItemId", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.getItemId(arg0); else retVal = eventDataExchange.getReturnData(); return (long)retVal;
    }
    //@Override
    public void notifyDataSetChanged() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("notifyDataSetChanged", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.notifyDataSetChanged();
    }
    //@Override
    public void notifyDataSetInvalidated() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("notifyDataSetInvalidated", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.notifyDataSetInvalidated();
    }
    //@Override
    public void registerDataSetObserver(android.database.DataSetObserver arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("registerDataSetObserver", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.registerDataSetObserver(arg0);
    }
    //@Override
    public void setAutofillOptions(java.lang.CharSequence[] arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setAutofillOptions", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setAutofillOptions(arg0);
    }
    //@Override
    public void unregisterDataSetObserver(android.database.DataSetObserver arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("unregisterDataSetObserver", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.unregisterDataSetObserver(arg0);
    }
    //@Override
    public void setDropDownViewResource(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setDropDownViewResource", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setDropDownViewResource(arg0);
    }
    //@Override
    public void setDropDownViewTheme(android.content.res.Resources.Theme arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setDropDownViewTheme", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setDropDownViewTheme(arg0);
    }
    //@Override
    public void setViewBinder(android.widget.SimpleAdapter.ViewBinder arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setViewBinder", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setViewBinder(arg0);
    }
    //@Override
    public void setViewImage(android.widget.ImageView arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setViewImage", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.setViewImage(arg0, arg1);
    }
    //@Override
    public void setViewImage(android.widget.ImageView arg0, java.lang.String arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setViewImage2", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.setViewImage(arg0, arg1);
    }
    //@Override
    public void setViewText(android.widget.TextView arg0, java.lang.String arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setViewText", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.setViewText(arg0, arg1);
    }

}