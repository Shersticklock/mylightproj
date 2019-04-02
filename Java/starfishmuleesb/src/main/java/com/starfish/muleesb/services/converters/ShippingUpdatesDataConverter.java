package com.starfish.muleesb.services.converters;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import com.starfish.muleesb.domain.shippingupdates.oms.ResponseData;
import com.starfish.muleesb.domain.shippingupdates.oms.ResponseShippingData;
import com.starfish.muleesb.domain.shippingupdates.oms.ResponseShippingItem;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrder;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderPackageItem;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekResponseData;

@Service
public class ShippingUpdatesDataConverter {

	public ResponseData convert(SdekResponseData source) {
		ResponseData result = new ResponseData();

		List<ResponseShippingData> responseShippingDataList = new ArrayList<ResponseShippingData>();

		for (SdekOrder sdekOrder : source.getOrders()) {
			ResponseShippingData shippingData = new ResponseShippingData();
			shippingData.setOrderId(sdekOrder.getNumber());
			shippingData.setShippingId(String.valueOf(sdekOrder.getDispatchNumber()));
			shippingData.setStatusId(String.valueOf(sdekOrder.getStatus().getCode()));

			if (sdekOrder.getOrderPackage() != null) {
				List<ResponseShippingItem> responseShippingItems = new ArrayList<ResponseShippingItem>();
				for (SdekOrderPackageItem sourceItem : sdekOrder.getOrderPackage().getItems()) {
					ResponseShippingItem item = new ResponseShippingItem();
					item.setItemId(sourceItem.getWareKey());
					item.setQuantity(sourceItem.getDeliveryAmount());
					responseShippingItems.add(item);
				}
				shippingData.setItems(responseShippingItems);
			}
			responseShippingDataList.add(shippingData);
		}

		result.setResult(responseShippingDataList);
		result.setMessage("Response received, see results array");
		result.setSuccess(true);
		return result;
	}

}
