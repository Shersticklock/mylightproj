package com.starfish.muleesb.services.converters;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

import com.starfish.muleesb.domain.shippingupdates.oms.ResponseData;
import com.starfish.muleesb.domain.shippingupdates.oms.ResponseShippingData;
import com.starfish.muleesb.domain.shippingupdates.oms.ResponseShippingItem;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrder;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderPackage;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderPackageItem;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderStatus;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekResponseData;

public class ShippingUpdatesDataConverterTest {

	@Test
	public void test() {
		SdekResponseData source = prepareTestData();
		ShippingUpdatesDataConverter converter = new ShippingUpdatesDataConverter();
		ResponseData result = converter.convert(source);

		assertNotNull(result);
		assertNotNull(result.getResult());
		assertTrue(result.getResult().size() == 1);

		ResponseShippingData resultData = result.getResult().get(0);
		assertNotNull(resultData);
		assertEquals(resultData.getOrderId(), "123");
		assertEquals(resultData.getShippingId(), "456");
		assertEquals(resultData.getStatusId(), "789");

		assertNotNull(resultData.getItems());
		assertTrue(resultData.getItems().size() == 1);
		ResponseShippingItem resultItem = resultData.getItems().get(0);
		assertNotNull(resultItem);
		assertEquals(resultItem.getItemId(), "4");
		assertTrue(resultItem.getQuantity() == 111);
	}

	private SdekResponseData prepareTestData() {
		SdekOrder sourceOrder = new SdekOrder();
		sourceOrder.setNumber("123");
		sourceOrder.setDispatchNumber(456);

		SdekOrderStatus sourceStatus = new SdekOrderStatus();
		sourceStatus.setCode(789);
		sourceOrder.setStatus(sourceStatus);

		List<SdekOrderPackageItem> sourceItems = new ArrayList<>();
		SdekOrderPackageItem sourceItem = new SdekOrderPackageItem();
		sourceItem.setDeliveryAmount(111);
		sourceItem.setWareKey("4");
		sourceItems.add(sourceItem);

		SdekOrderPackage sourcePackage = new SdekOrderPackage();
		sourcePackage.setItems(sourceItems);

		sourceOrder.setOrderPackage(sourcePackage);

		List<SdekOrder> sourceOrders = new ArrayList<SdekOrder>();
		sourceOrders.add(sourceOrder);

		SdekResponseData source = new SdekResponseData();
		source.setOrders(sourceOrders);

		return source;
	}

}
