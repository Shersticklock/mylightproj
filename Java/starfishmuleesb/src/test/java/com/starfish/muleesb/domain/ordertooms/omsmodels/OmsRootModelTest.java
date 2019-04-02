package com.starfish.muleesb.domain.ordertooms.omsmodels;


import static org.junit.Assert.*;

import java.io.IOException;

import org.codehaus.jackson.map.ObjectMapper;
import org.junit.Test;

public class OmsRootModelTest {

	@Test
	public void test() throws IOException {
		String sourceJson = "{\"id\":\"N-12345\",\"shop\":\"a1015\",\"firstName\":\"Виктор\",\"lastName\":\"Петров\","
				+ "\"phone\":\"7929552299\",\"needCall\":true,\"timeCreated\":\"2017-01-01 12:00:00\","
				+ "\"deliveryDate\":\"2017-05-05\",\"deliveryTimeFrom\":\"2017-05-05 12:00:00\","
				+ "\"items\":[{\"price\":1099.99,\"quantity\":1,\"name\":\"Футболка\",\"productId\":\"4srt34fw\"},"
				+ "{\"price\":199.99,\"estimatedWeight\":0.55,\"name\":\"Печенье\",\"productId\":\"234t34fw\"}],"
				+ "\"deliveryAddress\":{\"text\":\"ул. Орджоникидзе, д.11, Москва, 115419\",\"city\":\"Москва\","
				+ "\"street\":\"ул. Орджоникидзе\",\"housing\":\"11\",\"zip\":\"115419\",\"metro\":\"Ленинский проспект\"}}";
		
		ObjectMapper mapper = new ObjectMapper();
		OmsRootModel result = mapper.readValue(sourceJson, OmsRootModel.class);
		
		assertTrue(result.getId().equals("N-12345"));
		assertTrue(result.getShop().equals("a1015"));
		assertTrue(result.getFirstName().equals("Виктор"));
		assertTrue(result.getLastName().equals("Петров"));
		assertTrue(result.getPhone().equals("7929552299"));
		assertTrue(result.getNeedCall() == true);
		assertTrue(result.getTimeCreated().equals("2017-01-01 12:00:00"));
		assertTrue(result.getDeliveryDate().equals("2017-05-05"));
		assertTrue(result.getDeliveryTimeFrom().equals("2017-05-05 12:00:00"));
		
		assertTrue(result.getItems() != null);
		assertTrue(result.getItems().size() == 2);
		
		DeliveryAddressOms address = result.getDeliveryAddress();
		assertTrue(address.getText().equals("ул. Орджоникидзе, д.11, Москва, 115419"));
		assertTrue(address.getCity().equals("Москва"));
		assertTrue(address.getStreet().equals("ул. Орджоникидзе"));
		assertTrue(address.getHousing().equals("11"));
		assertTrue(address.getZip().equals("115419"));
		assertTrue(address.getMetro().equals("Ленинский проспект"));
	}

}
