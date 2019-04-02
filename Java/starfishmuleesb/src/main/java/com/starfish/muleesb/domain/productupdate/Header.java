package com.starfish.muleesb.domain.productupdate;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Header", namespace = "http://v8.1c.ru/messages")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class Header {
	
	private String exchangePlan;
	private String to;
	private String from;
	private int messageNumber;
	private int receivedNumber;


	@XmlElement(name = "ExchangePlan", namespace = "http://v8.1c.ru/messages")
	public String getExchangePlan() {
		return exchangePlan;
	}
	
	public void setExchangePlan(String exchangePlan) {
		this.exchangePlan = exchangePlan;
	}
	
	@XmlElement(name = "To", namespace = "http://v8.1c.ru/messages")
	public String getTo() {
		return to;
	}
	
	public void setTo(String to) {
		this.to = to;
	}
	
	@XmlElement(name = "From", namespace = "http://v8.1c.ru/messages")
	public String getFrom() {
		return from;
	}
	
	public void setFrom(String from) {
		this.from = from;
	}
	
	@XmlElement(name = "MessageNo", namespace = "http://v8.1c.ru/messages")
	public int getMessageNumber() {
		return messageNumber;
	}
	
	public void setMessageNumber(int messageNumber) {
		this.messageNumber = messageNumber;
	}
	
	@XmlElement(name = "ReceivedNo", namespace = "http://v8.1c.ru/messages")
	public int getReceivedNumber() {
		return receivedNumber;
	}
	
	public void setReceivedNumber(int receivedNumber) {
		this.receivedNumber = receivedNumber;
	}

}
