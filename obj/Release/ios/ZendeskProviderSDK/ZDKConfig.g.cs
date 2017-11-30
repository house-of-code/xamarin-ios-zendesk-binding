//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace ZendeskProviderSDK {
	[Register("ZDKConfig", true)]
	public unsafe partial class ZDKConfig : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ZDKConfig");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ZDKConfig () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ZDKConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ZDKConfig (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enablePushWithUAChannelID:callback:")]
		[CompilerGenerated]
		public unsafe virtual void EnablePush (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSObject, NSError> callback)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsidentifier = NSString.CreateNative (identifier);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDActionArity2V0.Handler, callback);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("enablePushWithUAChannelID:callback:"), nsidentifier, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("enablePushWithUAChannelID:callback:"), nsidentifier, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsidentifier);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initializeWithAppId:zendeskUrl:clientId:")]
		[CompilerGenerated]
		public virtual void InitializeWithAppId (string applicationId, string zendeskUrl, string oAuthClientId)
		{
			if (applicationId == null)
				throw new ArgumentNullException ("applicationId");
			if (zendeskUrl == null)
				throw new ArgumentNullException ("zendeskUrl");
			if (oAuthClientId == null)
				throw new ArgumentNullException ("oAuthClientId");
			var nsapplicationId = NSString.CreateNative (applicationId);
			var nszendeskUrl = NSString.CreateNative (zendeskUrl);
			var nsoAuthClientId = NSString.CreateNative (oAuthClientId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initializeWithAppId:zendeskUrl:clientId:"), nsapplicationId, nszendeskUrl, nsoAuthClientId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initializeWithAppId:zendeskUrl:clientId:"), nsapplicationId, nszendeskUrl, nsoAuthClientId);
			}
			NSString.ReleaseNative (nsapplicationId);
			NSString.ReleaseNative (nszendeskUrl);
			NSString.ReleaseNative (nsoAuthClientId);
			
		}
		
		[Export ("instance")]
		[CompilerGenerated]
		public static ZDKConfig Instance ()
		{
			return  Runtime.GetNSObject<ZDKConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("instance")));
		}
		
		[CompilerGenerated]
		public virtual IZDKIdentity UserIdentity {
			[Export ("userIdentity")]
			get {
				IZDKIdentity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IZDKIdentity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userIdentity")), false);
				} else {
					ret =  Runtime.GetINativeObject<IZDKIdentity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userIdentity")), false);
				}
				return ret;
			}
			
			[Export ("setUserIdentity:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserIdentity:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserIdentity:"), value.Handle);
				}
			}
		}
		
	} /* class ZDKConfig */
}
