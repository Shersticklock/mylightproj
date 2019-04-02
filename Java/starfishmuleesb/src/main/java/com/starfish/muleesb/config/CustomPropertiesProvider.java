package com.starfish.muleesb.config;

import java.util.Properties;

import org.springframework.beans.factory.config.PreferencesPlaceholderConfigurer;

public class CustomPropertiesProvider extends PreferencesPlaceholderConfigurer {

	private static final String FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER = "ftp.product.update.host";
	private static final String FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER = "ftp.product.update.port";
	private static final String FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER = "ftp.product.update.path";
	private static final String FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER = "ftp.product.update.username";
	private static final String FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER = "ftp.product.update.password";

	private static final String TEST_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER = "test.ftp.product.update.host";
	private static final String TEST_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER = "test.ftp.product.update.port";
	private static final String TEST_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER = "test.ftp.product.update.path";
	private static final String TEST_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER = "test.ftp.product.update.username";
	private static final String TEST_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER = "test.ftp.product.update.password";

	private static final String SITE_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER = "site.ftp.product.update.host";
	private static final String SITE_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER = "site.ftp.product.update.port";
	private static final String SITE_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER = "site.ftp.product.update.path";
	private static final String SITE_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER = "site.ftp.product.update.username";
	private static final String SITE_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER = "site.ftp.product.update.password";

	private static final String TEST_SITE_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER = "test.site.ftp.product.update.host";
	private static final String TEST_SITE_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER = "test.site.ftp.product.update.port";
	private static final String TEST_SITE_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER = "test.site.ftp.product.update.path";
	private static final String TEST_SITE_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER = "test.site.ftp.product.update.username";
	private static final String TEST_SITE_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER = "test.site.ftp.product.update.password";

	private static final String FTP_PRODUCT_UPDATE_INBOUND_PATTERN_PLACEHOLDER = "ftp.product.update.inboundpattern";
	private static final String FTP_PRODUCT_UPDATE_OUTBOUND_PATTERN_PLACEHOLDER = "ftp.product.update.outboundpattern";

	private static final String TEST_FTP_PRODUCT_UPDATE_INBOUND_PATTERN_PLACEHOLDER = "test.ftp.product.update.inboundpattern";
	private static final String TEST_FTP_PRODUCT_UPDATE_OUTBOUNT_PATTERN_PLACEHOLDER = "test.ftp.product.update.outboundpattern";

	private static final String MODE_PLACEHOLDER = "mode";
	private static final String PROD_MODE = "prod";

	@Override
	protected String resolvePlaceholder(String placeholder, Properties props) {

		if (FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER);
			}
		}

		if (SITE_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(SITE_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_SITE_FTP_PRODUCT_UPDATE_HOST_PLACEHOLDER);
			}
		}

		if (SITE_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(SITE_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_SITE_FTP_PRODUCT_UPDATE_PORT_PLACEHOLDER);
			}
		}

		if (SITE_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(SITE_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_SITE_FTP_PRODUCT_UPDATE_PATH_PLACEHOLDER);
			}
		}

		if (SITE_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(SITE_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_SITE_FTP_PRODUCT_UPDATE_USERNAME_PLACEHOLDER);
			}
		}

		if (SITE_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(SITE_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_SITE_FTP_PRODUCT_UPDATE_PASSWORD_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_INBOUND_PATTERN_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_INBOUND_PATTERN_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_INBOUND_PATTERN_PLACEHOLDER);
			}
		}

		if (FTP_PRODUCT_UPDATE_OUTBOUND_PATTERN_PLACEHOLDER.equals(placeholder)) {
			if (PROD_MODE.equals(props.getProperty(MODE_PLACEHOLDER))) {
				return props.getProperty(FTP_PRODUCT_UPDATE_OUTBOUND_PATTERN_PLACEHOLDER);
			} else {
				return props.getProperty(TEST_FTP_PRODUCT_UPDATE_OUTBOUNT_PATTERN_PLACEHOLDER);
			}
		}

		return super.resolvePlaceholder(placeholder, props);
	}

}
