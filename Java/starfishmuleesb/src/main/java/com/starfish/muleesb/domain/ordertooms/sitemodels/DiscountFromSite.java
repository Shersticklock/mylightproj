package com.starfish.muleesb.domain.ordertooms.sitemodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class DiscountFromSite {

	@JsonProperty("GUID_Discount")
	private String discountGuid;


	public String getDiscountGuid() {
		return discountGuid;
	}

	public void setDiscountGuid(String discountGuid) {
		this.discountGuid = discountGuid;
	}

}
