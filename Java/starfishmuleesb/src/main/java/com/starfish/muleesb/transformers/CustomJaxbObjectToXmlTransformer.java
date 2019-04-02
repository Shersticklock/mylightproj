package com.starfish.muleesb.transformers;

import java.io.IOException;
import java.io.StringWriter;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

import org.mule.api.transformer.TransformerException;
import org.mule.transformer.AbstractTransformer;
import org.springframework.beans.factory.annotation.Autowired;

import com.starfish.muleesb.jaxb.factory.JaxbContextProvider;

public class CustomJaxbObjectToXmlTransformer extends AbstractTransformer {

	private JaxbContextProvider provider;

	private String beanName;

	@Override
	protected Object doTransform(Object src, String enc) throws TransformerException {
		JAXBContext jaxbContext = provider.getContext(beanName);
		StringWriter sw = new StringWriter();
		try {
			Marshaller marshaller = jaxbContext.createMarshaller();
			marshaller.marshal(src, sw);
			String result = sw.toString();
			return result;
		} catch (JAXBException e) {
			throw new TransformerException(this, e);
		} finally {
			try {
				sw.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	public String getBeanName() {
		return beanName;
	}

	public void setBeanName(String beanName) {
		this.beanName = beanName;
	}

	@Autowired
	public void setProvider(JaxbContextProvider provider) {
		this.provider = provider;
	}

}
