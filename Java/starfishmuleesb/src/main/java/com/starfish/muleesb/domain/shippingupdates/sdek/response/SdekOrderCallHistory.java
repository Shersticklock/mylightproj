package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;

@XmlAccessorType(XmlAccessType.PROPERTY)
public class SdekOrderCallHistory {

	private List<SdekOrderCallGood> callGood;
	private List<SdekOrderCallFail> callFail;
	private List<SdekOrderCallDelay> callDelay;

	@XmlElementWrapper(name = "CallGood")
	@XmlElement(name = "Good")
	public List<SdekOrderCallGood> getCallGood() {
		return callGood;
	}

	public void setCallGood(List<SdekOrderCallGood> callGood) {
		this.callGood = callGood;
	}

	@XmlElementWrapper(name = "CallFail")
	@XmlElement(name = "Fail")
	public List<SdekOrderCallFail> getCallFail() {
		return callFail;
	}

	public void setCallFail(List<SdekOrderCallFail> callFail) {
		this.callFail = callFail;
	}

	@XmlElementWrapper(name = "CallDelay")
	@XmlElement(name = "Delay")
	public List<SdekOrderCallDelay> getCallDelay() {
		return callDelay;
	}

	public void setCallDelay(List<SdekOrderCallDelay> callDelay) {
		this.callDelay = callDelay;
	}

}
