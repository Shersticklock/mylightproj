package com.starfish.muleesb.domain.ordertooms.omsmodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class CustomAttributeFromOms {

	@JsonProperty("name")
	private String name;

	@JsonProperty("value")
	private String value;


	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getValue() {
		return value;
	}

	public void setValue(String value) {
		this.value = value;
	}

}
