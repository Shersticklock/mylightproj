package com.starfish.muleesb.domain.productupdate;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Message", namespace = "http://v8.1c.ru/messages")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class Message {

	private Header header;
	private Body body;


	@XmlElement(name = "Header", namespace = "http://v8.1c.ru/messages")
	public Header getHeader() {
		return header;
	}

	public void setHeader(Header header) {
		this.header = header;
	}

	@XmlElement(name = "Body", namespace = "http://v8.1c.ru/messages")
	public Body getBody() {
		return body;
	}

	public void setBody(Body body) {
		this.body = body;
	}

}
