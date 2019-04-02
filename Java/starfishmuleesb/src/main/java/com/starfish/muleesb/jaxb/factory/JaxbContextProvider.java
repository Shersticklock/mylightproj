package com.starfish.muleesb.jaxb.factory;

import java.util.Map;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;

import org.springframework.stereotype.Component;

import com.google.common.collect.Maps;
import com.starfish.muleesb.domain.productupdate.AssortmentType;
import com.starfish.muleesb.domain.productupdate.Body;
import com.starfish.muleesb.domain.productupdate.BoxLine;
import com.starfish.muleesb.domain.productupdate.City;
import com.starfish.muleesb.domain.productupdate.ClassifierOfCountry;
import com.starfish.muleesb.domain.productupdate.Collection;
import com.starfish.muleesb.domain.productupdate.Currency;
import com.starfish.muleesb.domain.productupdate.DiscountCard;
import com.starfish.muleesb.domain.productupdate.Header;
import com.starfish.muleesb.domain.productupdate.HeelType;
import com.starfish.muleesb.domain.productupdate.Language;
import com.starfish.muleesb.domain.productupdate.Message;
import com.starfish.muleesb.domain.productupdate.Product;
import com.starfish.muleesb.domain.productupdate.ProductBox;
import com.starfish.muleesb.domain.productupdate.ProductDesign;
import com.starfish.muleesb.domain.productupdate.ProductFile;
import com.starfish.muleesb.domain.productupdate.ProductGroup;
import com.starfish.muleesb.domain.productupdate.ProductType;
import com.starfish.muleesb.domain.productupdate.Region;
import com.starfish.muleesb.domain.productupdate.RetailClient;
import com.starfish.muleesb.domain.productupdate.Salon;
import com.starfish.muleesb.domain.productupdate.Season;
import com.starfish.muleesb.domain.productupdate.SimpleColor;
import com.starfish.muleesb.domain.productupdate.SimpleMaterial;
import com.starfish.muleesb.domain.productupdate.SizeClassifier;
import com.starfish.muleesb.domain.productupdate.Trademark;
import com.starfish.muleesb.domain.shippingupdates.sdek.request.ChangePeriod;
import com.starfish.muleesb.domain.shippingupdates.sdek.request.Order;
import com.starfish.muleesb.domain.shippingupdates.sdek.request.SdekRequestData;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrder;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderAttempt;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderCallDelay;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderCallFail;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderCallGood;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderCallHistory;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderDelayReason;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderDelayReasonState;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderPackage;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderPackageItem;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderReason;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderStatus;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekOrderStatusState;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekResponseData;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekReturnOrder;
import com.starfish.muleesb.domain.shippingupdates.sdek.response.SdekReturnOrderDelayReason;
import com.starfish.muleesb.domain.svyaznoy.SvyaznoyPayload;
import com.starfish.muleesb.domain.svyaznoy.SvyaznoyResponse;

/*
 * Поскольку Mule ESB не поддерживает одновременное существование нескольких JaxbContext,
 * приходится инициализировать их через фабрику.
 */
@Component
public class JaxbContextProvider {

	private static Map<String, JAXBContext> contexts = Maps.newHashMap();

	public static final String PRODUCT_UPDATE_CONTEXT_KEY = "productupdateJaxbContext";
	public static final String SHIPPING_UPDATES_CONTEXT_KEY = "shippingUpdatesJaxbContext";
	public static final String SVYAZNOY_CONTEXT_KEY = "svyaznoyJaxbContext";

	static {
		try {
			JAXBContext productUpdateContext = JAXBContext.newInstance(Product.class, SimpleColor.class,
					SizeClassifier.class, AssortmentType.class, ProductGroup.class, ProductType.class, HeelType.class,
					Season.class, Collection.class, ClassifierOfCountry.class, Trademark.class, SimpleMaterial.class,
					Currency.class, Language.class, RetailClient.class, ProductDesign.class, DiscountCard.class,
					Region.class, City.class, Salon.class, BoxLine.class, ProductBox.class, ProductFile.class,
					Message.class, Header.class, Body.class);
			contexts.put(PRODUCT_UPDATE_CONTEXT_KEY, productUpdateContext);

			JAXBContext shippingUpdatesContext = JAXBContext.newInstance(ChangePeriod.class, Order.class,
					SdekRequestData.class, SdekOrder.class, SdekOrderAttempt.class, SdekOrderCallDelay.class,
					SdekOrderCallFail.class, SdekOrderCallGood.class, SdekOrderCallHistory.class,
					SdekOrderDelayReason.class, SdekOrderDelayReasonState.class, SdekOrderPackage.class,
					SdekOrderPackageItem.class, SdekOrderReason.class, SdekOrderStatus.class,
					SdekOrderStatusState.class, SdekResponseData.class, SdekReturnOrder.class,
					SdekReturnOrderDelayReason.class);
			contexts.put(SHIPPING_UPDATES_CONTEXT_KEY, shippingUpdatesContext);

			JAXBContext svyaznoyContext = JAXBContext.newInstance(SvyaznoyResponse.class, SvyaznoyPayload.class);
			contexts.put(SVYAZNOY_CONTEXT_KEY, svyaznoyContext);
		} catch (JAXBException e) {
			e.printStackTrace();
		}
	}

	public JAXBContext getContext(String key) {
		return contexts.get(key);
	}

}
