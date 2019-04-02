package com.starfish.muleesb.domain.productupdate;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Body")
@XmlAccessorType(XmlAccessType.PROPERTY)
public class Body {
	
	private List<SimpleColor> simpleColors;
	private List<SizeClassifier> sizeClassifiers;
	private List<AssortmentType> assortmentTypes;
	private List<ProductGroup> productGroups;
	private List<ProductType> productTypes;
	private List<HeelType> heelTypes;
	private List<Season> seasons;
	private List<Collection> collections;
	private List<ClassifierOfCountry> classifierOfCountries;
	private List<Trademark> trademarks;
	private List<SimpleMaterial> simpleMaterials;
	private List<Currency> currencies;
	private List<Language> languages;
	private List<RetailClient> retailClients;
	private List<ProductDesign> productDesigns;
	private List<DiscountCard> discountCards;
	private List<Group> groups;
	private List<Region> regions;
	private List<City> cities;
	private List<Salon> salons;


	@XmlElementWrapper(name = "ПростыеЦвета")
	@XmlElement(name = "Элемент")
	public List<SimpleColor> getSimpleColors() {
		return simpleColors;
	}

	public void setSimpleColors(List<SimpleColor> simpleColors) {
		this.simpleColors = simpleColors;
	}

	@XmlElementWrapper(name = "КлассификаторРазмеров")
	@XmlElement(name = "Элемент")
	public List<SizeClassifier> getSizeClassifiers() {
		return sizeClassifiers;
	}

	public void setSizeClassifiers(List<SizeClassifier> sizeClassifiers) {
		this.sizeClassifiers = sizeClassifiers;
	}

	@XmlElementWrapper(name = "ВидАссортимента")
	@XmlElement(name = "Элемент")
	public List<AssortmentType> getAssortmentTypes() {
		return assortmentTypes;
	}

	public void setAssortmentTypes(List<AssortmentType> assortmentTypes) {
		this.assortmentTypes = assortmentTypes;
	}

	@XmlElementWrapper(name = "ТоварныеГруппы")
	@XmlElement(name = "Элемент")
	public List<ProductGroup> getProductGroups() {
		return productGroups;
	}

	public void setProductGroups(List<ProductGroup> productGroups) {
		this.productGroups = productGroups;
	}

	@XmlElementWrapper(name = "ТипыИзделий")
	@XmlElement(name = "Элемент")
	public List<ProductType> getProductTypes() {
		return productTypes;
	}

	public void setProductTypes(List<ProductType> productTypes) {
		this.productTypes = productTypes;
	}

	@XmlElementWrapper(name = "ТипыКаблуков")
	@XmlElement(name = "Элемент")
	public List<HeelType> getHeelTypes() {
		return heelTypes;
	}

	public void setHeelTypes(List<HeelType> heelTypes) {
		this.heelTypes = heelTypes;
	}

	@XmlElementWrapper(name = "Сезоны")
	@XmlElement(name = "Элемент")
	public List<Season> getSeasons() {
		return seasons;
	}

	public void setSeasons(List<Season> seasons) {
		this.seasons = seasons;
	}

	@XmlElementWrapper(name = "Коллекции")
	@XmlElement(name = "Элемент")
	public List<Collection> getCollections() {
		return collections;
	}

	public void setCollections(List<Collection> collections) {
		this.collections = collections;
	}

	@XmlElementWrapper(name = "КлассификаторСтранМира")
	@XmlElement(name = "Элемент")
	public List<ClassifierOfCountry> getClassifierOfCountries() {
		return classifierOfCountries;
	}

	public void setClassifierOfCountries(List<ClassifierOfCountry> classifierOfCountries) {
		this.classifierOfCountries = classifierOfCountries;
	}

	@XmlElementWrapper(name = "ТорговыеМарки")
	@XmlElement(name = "Элемент")
	public List<Trademark> getTrademarks() {
		return trademarks;
	}

	public void setTrademarks(List<Trademark> trademarks) {
		this.trademarks = trademarks;
	}

	@XmlElementWrapper(name = "ПростыеМатериалы")
	@XmlElement(name = "Элемент")
	public List<SimpleMaterial> getSimpleMaterials() {
		return simpleMaterials;
	}

	public void setSimpleMaterials(List<SimpleMaterial> simpleMaterials) {
		this.simpleMaterials = simpleMaterials;
	}

	@XmlElementWrapper(name = "Валюты")
	@XmlElement(name = "Элемент")
	public List<Currency> getCurrencies() {
		return currencies;
	}

	public void setCurrencies(List<Currency> currencies) {
		this.currencies = currencies;
	}

	@XmlElementWrapper(name = "Языки")
	@XmlElement(name = "Элемент")
	public List<Language> getLanguages() {
		return languages;
	}

	public void setLanguages(List<Language> languages) {
		this.languages = languages;
	}

	@XmlElementWrapper(name = "РозничныеКлиенты")
	@XmlElement(name = "Элемент")
	public List<RetailClient> getRetailClients() {
		return retailClients;
	}

	public void setRetailClients(List<RetailClient> retailClients) {
		this.retailClients = retailClients;
	}

	@XmlElementWrapper(name = "КонструкцииИзделий")
	@XmlElement(name = "Элемент")
	public List<ProductDesign> getProductDesigns() {
		return productDesigns;
	}

	public void setProductDesigns(List<ProductDesign> productDesigns) {
		this.productDesigns = productDesigns;
	}

	@XmlElementWrapper(name = "ДисконтныеКарты")
	@XmlElement(name = "Элемент")
	public List<DiscountCard> getDiscountCards() {
		return discountCards;
	}

	public void setDiscountCards(List<DiscountCard> discountCards) {
		this.discountCards = discountCards;
	}

	@XmlElementWrapper(name = "Товары")
	@XmlElement(name = "Группа")
	public List<Group> getGroups() {
		return groups;
	}

	public void setGroups(List<Group> groups) {
		this.groups = groups;
	}

	@XmlElementWrapper(name = "Регионы")
	@XmlElement(name = "Элемент")
	public List<Region> getRegions() {
		return regions;
	}

	public void setRegions(List<Region> regions) {
		this.regions = regions;
	}

	@XmlElementWrapper(name = "Города")
	@XmlElement(name = "Элемент")
	public List<City> getCities() {
		return cities;
	}

	public void setCities(List<City> cities) {
		this.cities = cities;
	}

	@XmlElementWrapper(name = "Салоны")
	@XmlElement(name = "Элемент")
	public List<Salon> getSalons() {
		return salons;
	}

	public void setSalons(List<Salon> salons) {
		this.salons = salons;
	}

}
