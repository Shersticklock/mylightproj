package com.starfish.muleesb.services.converters;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import com.starfish.muleesb.domain.ordertooms.omsmodels.CustomAttributeFromOms;
import com.starfish.muleesb.domain.ordertooms.omsmodels.DeliveryAddressOms;
import com.starfish.muleesb.domain.ordertooms.omsmodels.OmsRootModel;
import com.starfish.muleesb.domain.ordertooms.omsmodels.PersonalDiscountFromOms;
import com.starfish.muleesb.domain.ordertooms.omsmodels.ProductOrderItemFromOms;
import com.starfish.muleesb.domain.ordertooms.sitemodels.DiscountFromSite;
import com.starfish.muleesb.domain.ordertooms.sitemodels.ProductOrderItemFromSite;
import com.starfish.muleesb.domain.ordertooms.sitemodels.SiteRootModel;

public class AddOrderToOmsConverter {

	SimpleDateFormat dateOnlyFormatter;
	SimpleDateFormat dateAndTimeFormatter;

	public AddOrderToOmsConverter() {
		dateOnlyFormatter = new SimpleDateFormat("yyyy-MM-dd");
		dateAndTimeFormatter = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
	}

	public OmsRootModel convert(SiteRootModel source) {
		OmsRootModel target = new OmsRootModel();
		target.setId(source.getOrderId());
		target.setShop("mascotte");
		
		if (isNotEmpty(source.getOrderGuid())) {
			CustomAttributeFromOms customAttribute = new CustomAttributeFromOms();
			customAttribute.setName("order_guid");
			customAttribute.setValue(source.getOrderGuid());
			List<CustomAttributeFromOms> customAttributes = new ArrayList<CustomAttributeFromOms>(1);
			customAttributes.add(customAttribute);
			target.setCustomAttributes(customAttributes);
		}

		if (isNotEmpty(source.getDateCreateIS())) {
			String srcDate = source.getDateCreateIS();
			String targetDate = srcDate.substring(0, srcDate.indexOf("+"));
			targetDate = targetDate.replace('T', ' ');
			target.setTimeCreated(targetDate);
		}

		if (source.getDeliveryCost() != null) {
			target.setDeliveryCost(source.getDeliveryCost());
		}

		if (isNotEmpty(source.getShippingType())) {
			target.setDeliveryType(source.getShippingType());
		}

		if (isNotEmpty(source.getPaymentType())) {
			target.setPaymentType(source.getPaymentType());
		}

		if (isNotEmpty(source.getDiscountCard())) {
			target.setLoyaltyCardId(source.getDiscountCard());
		}

		if (isNotEmpty(source.getStatusOrder())) {
			target.setStatus(source.getStatusOrder());
		}

		if (isNotEmpty(source.getDateOfPayment())) {
			try {
				Date date = dateOnlyFormatter.parse(source.getDateOfPayment());
				String dateStr = dateAndTimeFormatter.format(date);
				target.setTimePaid(dateStr);
				target.setIsPaid(true);
			} catch (ParseException e) {
				target.setIsPaid(false);
			}
		}

		if (source.getSummaPayment() != null) {
			target.setSumPaid(source.getSummaPayment());
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getCustomerGuid())) {
			target.setCustomerId(source.getContactIS().getCustomerGuid());
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getLastName())) {
			target.setLastName(source.getContactIS().getLastName());
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getFirstName())) {
			target.setFirstName(source.getContactIS().getFirstName());
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getMobilePhone())) {
			target.setPhone(source.getContactIS().getMobilePhone());
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getDeliveryComment())) {
			target.setCustomerComment(source.getContactIS().getDeliveryComment());
		}

		target.setDeliveryAddress(parseDeliveryAddress(source));

		if (source.getBonusCalculated() != null) {
			target.setLoyaltyBonusEarn(source.getBonusCalculated());
		}

		if (source.getBonusClosed() != null) {
			target.setLoyaltyBonusBurn(source.getBonusClosed());
		}

		target.setItems(parseItems(source));

		target.setPersonalDiscounts(parseDiscounts(source));

		return target;
	}

	private List<PersonalDiscountFromOms> parseDiscounts(SiteRootModel source) {
		List<PersonalDiscountFromOms> result = new ArrayList<PersonalDiscountFromOms>();
		for (DiscountFromSite siteDiscount : source.getManualDiscounts()) {
			PersonalDiscountFromOms discount = new PersonalDiscountFromOms();
			discount.setId(siteDiscount.getDiscountGuid());
			discount.setCode("manual");
			result.add(discount);
		}
		for (DiscountFromSite siteDiscount : source.getDiscounts()) {
			PersonalDiscountFromOms discount = new PersonalDiscountFromOms();
			discount.setId(siteDiscount.getDiscountGuid());
			discount.setCode("regular");
			result.add(discount);
		}

		if (result.isEmpty()) {
			return null;
		}

		return result;
	}

	private List<ProductOrderItemFromOms> parseItems(SiteRootModel source) {
		List<ProductOrderItemFromOms> result = new ArrayList<ProductOrderItemFromOms>();
		for (ProductOrderItemFromSite siteItem : source.getGoods()) {
			ProductOrderItemFromOms item = new ProductOrderItemFromOms();
			String id = siteItem.getProductId();
			if (isNotEmpty(siteItem.getSizeId())) {
				id += "_" + siteItem.getSizeId();
				CustomAttributeFromOms customAttribute = new CustomAttributeFromOms();
				customAttribute.setName("size");
				customAttribute.setValue(siteItem.getSizeId());
				List<CustomAttributeFromOms> customAttributes = new ArrayList<CustomAttributeFromOms>(1);
				customAttributes.add(customAttribute);
				item.setCustomAttributes(customAttributes);
			} else {
				item.setCustomAttributes(null);
			}
			item.setProductId(id);

			if (siteItem.getQuantity() != null) {
				item.setQuantity(siteItem.getQuantity());
			} else {
				item.setQuantity(1);
			}

			if (siteItem.getPriceInitial() != null) {
				item.setPrice(siteItem.getPriceInitial());
			}

			if (siteItem.getPrice() != null) {
				item.setDiscount(siteItem.getPrice());
			}

			result.add(item);
		}
		return result;
	}

	private DeliveryAddressOms parseDeliveryAddress(SiteRootModel source) {
		boolean isEmpty = true;
		DeliveryAddressOms result = new DeliveryAddressOms();

		if (isNotEmpty(source.getStoreHouse())) {
			result.setPickupShop(source.getStoreHouse());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getCity())) {
			result.setCity(source.getContactIS().getCity());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getCityId())) {
			result.setCityId(source.getContactIS().getCityId());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getStreet())) {
			result.setStreet(source.getContactIS().getStreet());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getHouse())) {
			result.setBuilding(source.getContactIS().getHouse());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getBuilding())) {
			result.setHousing(source.getContactIS().getBuilding());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getGate())) {
			result.setGate(source.getContactIS().getGate());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getRoom())) {
			result.setFlat(source.getContactIS().getRoom());
			isEmpty = false;
		}

		if (source.getContactIS() != null && isNotEmpty(source.getContactIS().getIndex())) {
			result.setZip(source.getContactIS().getIndex());
			isEmpty = false;
		}

		if (isEmpty) {
			return null;
		}

		return result;
	}

	private boolean isNotEmpty(String str) {
		return str != null && !str.isEmpty();
	}

}
