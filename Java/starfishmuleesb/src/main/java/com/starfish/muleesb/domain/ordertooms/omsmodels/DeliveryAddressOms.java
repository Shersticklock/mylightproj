package com.starfish.muleesb.domain.ordertooms.omsmodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class DeliveryAddressOms {

	@JsonProperty("text")
	private String text;

	@JsonProperty("city")
	private String city;

	@JsonProperty("cityId")
	private String cityId;

	@JsonProperty("street")
	private String street;

	@JsonProperty("building")
	private String building;

	@JsonProperty("housing")
	private String housing;

	@JsonProperty("gate")
	private String gate;

	@JsonProperty("flat")
	private String flat;

	@JsonProperty("zip")
	private String zip;

	@JsonProperty("metro")
	private String metro;

	@JsonProperty("pickupShop")
	private String pickupShop;


	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getCityId() {
		return cityId;
	}

	public void setCityId(String cityId) {
		this.cityId = cityId;
	}

	public String getBuilding() {
		return building;
	}

	public void setBuilding(String building) {
		this.building = building;
	}

	public String getHousing() {
		return housing;
	}

	public void setHousing(String housing) {
		this.housing = housing;
	}

	public String getGate() {
		return gate;
	}

	public void setGate(String gate) {
		this.gate = gate;
	}

	public String getFlat() {
		return flat;
	}

	public void setFlat(String flat) {
		this.flat = flat;
	}

	public String getZip() {
		return zip;
	}

	public void setZip(String zip) {
		this.zip = zip;
	}

	public String getMetro() {
		return metro;
	}

	public void setMetro(String metro) {
		this.metro = metro;
	}

	public String getPickupShop() {
		return pickupShop;
	}

	public void setPickupShop(String pickupShop) {
		this.pickupShop = pickupShop;
	}

	public String getStreet() {
		return street;
	}

	public void setStreet(String street) {
		this.street = street;
	}

}
