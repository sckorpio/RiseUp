using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using System;

public class addmanager_script : MonoBehaviour 
{
	public BannerView bannerview;
	public InterstitialAd regularad;
	private string appID="ca-app-pub-5133215721502784~7588202759";
	private string regularID="ca-app-pub-5133215721502784/3265814366";
	// Use this for initialization
	void Start () 
	{
		MobileAds.Initialize (appID);
		//RequestAd ();
		RequestBanner ();
	}


	// Update is called once per frame
	void Update () 
	{

	}

	public void OnClickShowBanner()
	{
		this.RequestBanner ();
	}

	public void OnClickShowAd()
	{
		this.RequestAd ();
	}

	private void RequestAd()
	{
		regularad = new InterstitialAd (regularID);
		AdRequest request = new AdRequest.Builder ().Build ();
		regularad.LoadAd (request);
	}

	private void RequestBanner()
	{
		#if UNITY_ANDROID
		string bannerID = "ca-app-pub-5133215721502784/6909545908";
		#elif UNITY_IPHONE
		string adUnitId = bannerID;
		#else
		string bannerID  ="ca-app-pub-5133215721502784/6909545908";
		#endif

		bannerview = new BannerView (bannerID, AdSize.Banner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder ().Build ();
		bannerview.LoadAd (request);
		bannerview.Show ();
		//bannerview.OnAdLoaded += HandleOnAdLoaded;

	}

	void HandleOnAdLoaded(object a, EventArgs args)
	{
		print ("loaded");
		bannerview.Show ();
	}

	public void Show()
	{
		if (regularad.IsLoaded ()) 
		{
		   regularad.Show ();
		 }

	}

}
