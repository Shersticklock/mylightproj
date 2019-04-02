package com.starfish.muleesb.domain.shippingupdates.sdek.response;

import static org.junit.Assert.*;

import java.io.File;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

import org.junit.Test;

public class SdekResponseDataTest {

	@Test
	public void testResponseParsing1() throws JAXBException {
		File file = new File(getClass().getResource("/sdek/sdek-response-1.xml").getFile());
		JAXBContext context = JAXBContext.newInstance(SdekOrder.class, SdekOrderAttempt.class,
				SdekOrderCallDelay.class, SdekOrderCallFail.class, SdekOrderCallGood.class,
				SdekOrderCallHistory.class, SdekOrderDelayReason.class, SdekOrderDelayReasonState.class,
				SdekOrderPackage.class, SdekOrderPackageItem.class, SdekOrderReason.class,
				SdekOrderStatus.class, SdekOrderStatusState.class, SdekResponseData.class,
				SdekReturnOrder.class, SdekReturnOrderDelayReason.class);
		Unmarshaller unmarshaller = context.createUnmarshaller();
		SdekResponseData result = (SdekResponseData) unmarshaller.unmarshal(file);
		
		assertNotNull(result);
		assertEquals(result.getDateFirst(), "2013-07-16T00:00:00");
		assertNull(result.getDateLast());
		
		assertNotNull(result.getOrders());
		assertTrue(result.getOrders().size() == 2);
		result.getOrders().removeIf((SdekOrder order) -> {
			return !order.getNumber().equals("6346860");
		});
		assertTrue(result.getOrders().size() == 1);
		
		SdekOrder order = result.getOrders().get(0);
		assertTrue(order.getStatus().getCode() == 4);
		assertEquals(order.getActNumber(), "236");
		assertEquals(order.getNumber(), "6346860");
		assertTrue(order.getDispatchNumber() == 1001013928);
		
		assertNotNull(order.getOrderPackage());
		order.getOrderPackage().getItems().sort((SdekOrderPackageItem arg1, SdekOrderPackageItem arg2) -> {
			return Long.compare(
					Long.valueOf(arg1.getWareKey()),
					Long.valueOf(arg2.getWareKey()));
		});
		
		SdekOrderPackageItem item1 = order.getOrderPackage().getItems().get(0);
		assertEquals(item1.getWareKey(), "25000050368");
		assertTrue(item1.getDeliveryAmount() == 8);
		
		SdekOrderPackageItem item2 = order.getOrderPackage().getItems().get(1);
		assertEquals(item2.getWareKey(), "25000348563");
		assertTrue(item2.getDeliveryAmount() == 3);
		
		assertNull(order.getReturnOrders());
	}
	
	@Test
	public void testResponseParsing2() throws JAXBException {
		File file = new File(getClass().getResource("/sdek/sdek-response-2.xml").getFile());
		JAXBContext context = JAXBContext.newInstance(SdekOrder.class, SdekOrderAttempt.class,
				SdekOrderCallDelay.class, SdekOrderCallFail.class, SdekOrderCallGood.class,
				SdekOrderCallHistory.class, SdekOrderDelayReason.class, SdekOrderDelayReasonState.class,
				SdekOrderPackage.class, SdekOrderPackageItem.class, SdekOrderReason.class,
				SdekOrderStatus.class, SdekOrderStatusState.class, SdekResponseData.class,
				SdekReturnOrder.class, SdekReturnOrderDelayReason.class);
		Unmarshaller unmarshaller = context.createUnmarshaller();
		SdekResponseData result = (SdekResponseData) unmarshaller.unmarshal(file);
		

		assertNotNull(result);
		assertEquals(result.getDateFirst(), "2000-12-31T18:00:00+00:00");
		assertEquals(result.getDateLast(), "2015-10-15T09:59:35+00:00");
		
		assertNotNull(result.getOrders());
		assertTrue(result.getOrders().size() == 1);
		
		SdekOrder order = result.getOrders().get(0);
		assertTrue(order.getStatus().getCode() == 5);
		assertEquals(order.getActNumber(), "51844");
		assertEquals(order.getNumber(), "51844");
		assertTrue(order.getDispatchNumber() == 1014263974);
		assertNull(order.getOrderPackage());
		
		assertNotNull(order.getReturnOrders());
		assertTrue(order.getReturnOrders().size() == 1);
	}

}
