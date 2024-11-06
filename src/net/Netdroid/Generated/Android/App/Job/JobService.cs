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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Job
{
    #region JobService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/job/JobService.html"/>
    /// </summary>
    public partial class JobService : Android.App.Service
    {
        const string _bridgeClassName = "android.app.job.JobService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JobService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JobService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JobService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JobService(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region JobService implementation
    public partial class JobService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#JOB_END_NOTIFICATION_POLICY_DETACH"/>
        /// </summary>
        public static int JOB_END_NOTIFICATION_POLICY_DETACH { get { if (!_JOB_END_NOTIFICATION_POLICY_DETACHReady) { _JOB_END_NOTIFICATION_POLICY_DETACHContent = SGetField<int>(LocalBridgeClazz, "JOB_END_NOTIFICATION_POLICY_DETACH"); _JOB_END_NOTIFICATION_POLICY_DETACHReady = true; } return _JOB_END_NOTIFICATION_POLICY_DETACHContent; } }
        private static int _JOB_END_NOTIFICATION_POLICY_DETACHContent = default;
        private static bool _JOB_END_NOTIFICATION_POLICY_DETACHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#JOB_END_NOTIFICATION_POLICY_REMOVE"/>
        /// </summary>
        public static int JOB_END_NOTIFICATION_POLICY_REMOVE { get { if (!_JOB_END_NOTIFICATION_POLICY_REMOVEReady) { _JOB_END_NOTIFICATION_POLICY_REMOVEContent = SGetField<int>(LocalBridgeClazz, "JOB_END_NOTIFICATION_POLICY_REMOVE"); _JOB_END_NOTIFICATION_POLICY_REMOVEReady = true; } return _JOB_END_NOTIFICATION_POLICY_REMOVEContent; } }
        private static int _JOB_END_NOTIFICATION_POLICY_REMOVEContent = default;
        private static bool _JOB_END_NOTIFICATION_POLICY_REMOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#PERMISSION_BIND"/>
        /// </summary>
        public static Java.Lang.String PERMISSION_BIND { get { if (!_PERMISSION_BINDReady) { _PERMISSION_BINDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PERMISSION_BIND"); _PERMISSION_BINDReady = true; } return _PERMISSION_BINDContent; } }
        private static Java.Lang.String _PERMISSION_BINDContent = default;
        private static bool _PERMISSION_BINDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onStartJob(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnStartJob(Android.App.Job.JobParameters arg0)
        {
            return IExecuteWithSignature<bool>("onStartJob", "(Landroid/app/job/JobParameters;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onStopJob(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnStopJob(Android.App.Job.JobParameters arg0)
        {
            return IExecuteWithSignature<bool>("onStopJob", "(Landroid/app/job/JobParameters;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#jobFinished(android.app.job.JobParameters,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void JobFinished(Android.App.Job.JobParameters arg0, bool arg1)
        {
            IExecuteWithSignature("jobFinished", "(Landroid/app/job/JobParameters;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#setNotification(android.app.job.JobParameters,int,android.app.Notification,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.App.Notification"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetNotification(Android.App.Job.JobParameters arg0, int arg1, Android.App.Notification arg2, int arg3)
        {
            IExecuteWithSignature("setNotification", "(Landroid/app/job/JobParameters;ILandroid/app/Notification;I)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateEstimatedNetworkBytes(android.app.job.JobParameters,android.app.job.JobWorkItem,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="Android.App.Job.JobWorkItem"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public void UpdateEstimatedNetworkBytes(Android.App.Job.JobParameters arg0, Android.App.Job.JobWorkItem arg1, long arg2, long arg3)
        {
            IExecuteWithSignature("updateEstimatedNetworkBytes", "(Landroid/app/job/JobParameters;Landroid/app/job/JobWorkItem;JJ)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateEstimatedNetworkBytes(android.app.job.JobParameters,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void UpdateEstimatedNetworkBytes(Android.App.Job.JobParameters arg0, long arg1, long arg2)
        {
            IExecuteWithSignature("updateEstimatedNetworkBytes", "(Landroid/app/job/JobParameters;JJ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateTransferredNetworkBytes(android.app.job.JobParameters,android.app.job.JobWorkItem,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="Android.App.Job.JobWorkItem"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public void UpdateTransferredNetworkBytes(Android.App.Job.JobParameters arg0, Android.App.Job.JobWorkItem arg1, long arg2, long arg3)
        {
            IExecuteWithSignature("updateTransferredNetworkBytes", "(Landroid/app/job/JobParameters;Landroid/app/job/JobWorkItem;JJ)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateTransferredNetworkBytes(android.app.job.JobParameters,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void UpdateTransferredNetworkBytes(Android.App.Job.JobParameters arg0, long arg1, long arg2)
        {
            IExecuteWithSignature("updateTransferredNetworkBytes", "(Landroid/app/job/JobParameters;JJ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onNetworkChanged(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        public void OnNetworkChanged(Android.App.Job.JobParameters arg0)
        {
            IExecuteWithSignature("onNetworkChanged", "(Landroid/app/job/JobParameters;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}