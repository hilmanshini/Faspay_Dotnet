﻿using System;
using FaspaySDK.Credit.Conf;
using FaspaySDK.Credit.Entity.Payment.Wrapper;
namespace FaspaySDK.Credit.Entity.Payment
{
    public class FaspayPaymentCreditWrapperProd: FaspayPaymentCreditProd
    {
        FaspayPaymentCreditShopperData shopperData;

        FaspayPaymentCreditConfigApp app;
        FaspayUserCredit user;
        FaspayPaymentCreditTransactionData transactionData;
        FaspayPaymentCreditBillData billData;
        FaspayPaymentCreditShippingdata shippingdata;
        FaspayPaymentCreditItemData itemData;
        FaspayPaymentCreditDomicileData domicileData;
        FaspayPaymentCreditCardData cardData;

        public FaspayPaymentCreditWrapperProd(FaspayUserCredit user, FaspayPaymentCreditTransactionData transactionData, FaspayPaymentCreditShopperData shopperData, FaspayPaymentCreditConfigApp app, FaspayPaymentCreditBillData billData, FaspayPaymentCreditShippingdata shippingdata, FaspayPaymentCreditItemData itemData, FaspayPaymentCreditDomicileData domicileData, FaspayPaymentCreditCardData cardData)
        {
            this.card_issuer_bank = cardData.card_issuer_bank;
            this.card_identity_ref_type = cardData.card_identity_ref_type;
            this.card_identity_ref = cardData.card_identity_ref;
            this.card_phone = cardData.card_phone;
            this.card_bill_addr = cardData.card_bill_addr;
            this.card_bill_addr_poscode = cardData.card_bill_addr_poscode;
            this.card_bill_addr_city = cardData.card_bill_addr_city;
            this.card_bill_addr_region = cardData.card_bill_addr_region;
            this.card_bill_addr_state = cardData.card_bill_addr_state;
            this.card_bill_addr_country_code = cardData.card_bill_addr_country_code;
            this.card_email = cardData.card_email;
            this.cardData = cardData;



            this.domicile_address = domicileData.domicile_address;
            this.domicile_address_city = domicileData.domicile_address_city;
            this.domicile_address_region = domicileData.domicile_address_region;
            this.domicile_address_state = domicileData.domicile_address_state;
            this.domicile_address_poscode = domicileData.domicile_address_poscode;
            this.domicile_address_country_code = domicileData.domicile_address_country_code;
            this.domicile_phone_no = domicileData.domicile_phone_no;
            this.domicileData = domicileData;



            this.receiver_name_for_shipping = shippingdata.receiver_name_for_shipping;
            this.shipping_address = shippingdata.shipping_address;
            this.shipping_address_city = shippingdata.shipping_address_city;
            this.shipping_address_region = shippingdata.shipping_address_region;
            this.shipping_address_state = shippingdata.shipping_address_state;
            this.shipping_address_poscode = shippingdata.shipping_address_poscode;
            this.shipping_address_country_code = shippingdata.shipping_address_country_code;
            this.shippingcost = shippingdata.shippingcost;
            this.shippingdata = shippingdata;


            this.mref1 = itemData.mref1;
            this.mref2 = itemData.mref2;
            this.mref3 = itemData.mref3;
            this.mref4 = itemData.mref4;
            this.mref5 = itemData.mref5;
            this.mref6 = itemData.mref6;
            this.mref7 = itemData.mref7;
            this.mref8 = itemData.mref8;
            this.mref9 = itemData.mref9;
            this.mref10 = itemData.mref10;
            this.itemData = itemData;



            this.response_type = app.response_type;
            this.return_url = app.return_url;
            this.mparam1 = app.mparam1;
            this.mparam2 = app.mparam2;
            this.frisk1 = app.frisk1;
            this.frisk2 = app.frisk2;
            this.handshake_url = app.handshake_url;
            this.handshake_param = app.handshake_param;
            this.app = app;


            this.billing_address = billData.billing_address;
            this.billing_address_city = billData.billing_address_city;
            this.billing_address_region = billData.billing_address_region;
            this.billing_address_state = billData.billing_address_state;
            this.billing_address_poscode = billData.billing_address_poscode;
            this.billing_address_country_code = billData.billing_address_country_code;
            this.billData = billData;


            setMerchantid(user.getMerchantId());
            this.user = user;


            this.merchant_tranid = transactionData.merchant_tranid;
            this.currencycode = transactionData.currencycode;
            this.amount = transactionData.amount + ".00";
            this.user = transactionData.usr;
            this.signature = transactionData.signature;
            this.transactionData = transactionData;



            this.custname = shopperData.custname;
            this.custemail = shopperData.custemail;
            this.shopper_ip = shopperData.shopper_ip;
            this.description = shopperData.description;
            this.cardno = shopperData.cardno;
            this.cardname = shopperData.cardname;
            this.cardtype = Char.ToString(shopperData.cardtype);
            this.expirymonth = shopperData.expirymonth;
            this.expiryyear = shopperData.expiryyear;
            this.cardcvc = shopperData.cardcvc;
            this.card_issuer_bank_country_code = shopperData.card_issuer_bank_country_code;
            this.phone_no = shopperData.phone_no;
            this.customer_ref = shopperData.customer_ref;
            this.shopperData = shopperData;


            setMerchant_tranid(transactionData.getMerchant_tranid());
            //PYMT IND
            setPymt_ind("card_range_ind");
            setPymt_criteria("credit_card");
            //PYMT CRIT
            setCurrencycode(transactionData.getCurrencycode());


            setAmount((transactionData.getAmount().ToString("0.00")));
            setSignature(transactionData.getSignature());

        }

        public String getCard_issuer_bank()
        {
            return cardData.getCard_issuer_bank();
        }

        public void setCard_issuer_bank(String card_issuer_bank)
        {
            cardData.setCard_issuer_bank(card_issuer_bank);
        }

        public String getCard_identity_ref_type()
        {
            return cardData.getCard_identity_ref_type();
        }

        public void setCard_identity_ref_type(String card_identity_ref_type)
        {
            cardData.setCard_identity_ref_type(card_identity_ref_type);
        }

        public String getCard_identity_ref()
        {
            return cardData.getCard_identity_ref();
        }

        public void setCard_identity_ref(String card_identity_ref)
        {
            cardData.setCard_identity_ref(card_identity_ref);
        }

        public String getCard_phone()
        {
            return cardData.getCard_phone();
        }

        public void setCard_phone(String card_phone)
        {
            cardData.setCard_phone(card_phone);
        }

        public String getCard_bill_addr()
        {
            return cardData.getCard_bill_addr();
        }

        public void setCard_bill_addr(String card_bill_addr)
        {
            cardData.setCard_bill_addr(card_bill_addr);
        }

        public String getCard_bill_addr_poscode()
        {
            return cardData.getCard_bill_addr_poscode();
        }

        public void setCard_bill_addr_poscode(String card_bill_addr_poscode)
        {
            cardData.setCard_bill_addr_poscode(card_bill_addr_poscode);
        }

        public String getCard_bill_addr_city()
        {
            return cardData.getCard_bill_addr_city();
        }

        public void setCard_bill_addr_city(String card_bill_addr_city)
        {
            cardData.setCard_bill_addr_city(card_bill_addr_city);
        }

        public String getCard_bill_addr_region()
        {
            return cardData.getCard_bill_addr_region();
        }

        public void setCard_bill_addr_region(String card_bill_addr_region)
        {
            cardData.setCard_bill_addr_region(card_bill_addr_region);
        }

        public String getCard_bill_addr_state()
        {
            return cardData.getCard_bill_addr_state();
        }

        public void setCard_bill_addr_state(String card_bill_addr_state)
        {
            cardData.setCard_bill_addr_state(card_bill_addr_state);
        }

        public String getCard_bill_addr_country_code()
        {
            return cardData.getCard_bill_addr_country_code();
        }

        public void setCard_bill_addr_country_code(String card_bill_addr_country_code)
        {
            cardData.setCard_bill_addr_country_code(card_bill_addr_country_code);
        }

        public String getCard_email()
        {
            return cardData.getCard_email();
        }

        public void setCard_email(String card_email)
        {
            cardData.setCard_email(card_email);
        }

        public String getHandshake_url()
        {
            return app.getHandshake_url();
        }

        public void setHandshake_url(String handshake_url)
        {
            app.setHandshake_url(handshake_url);
        }

        public String getHandshake_param()
        {
            return app.getHandshake_param();
        }

        public void setHandshake_param(String handshake_param)
        {
            app.setHandshake_param(handshake_param);
        }

        public String getDomicile_address()
        {
            return domicileData.getDomicile_address();
        }

        public void setDomicile_address(String domicile_address)
        {
            domicileData.setDomicile_address(domicile_address);
        }

        public String getDomicile_address_city()
        {
            return domicileData.getDomicile_address_city();
        }

        public void setDomicile_address_city(String domicile_address_city)
        {
            domicileData.setDomicile_address_city(domicile_address_city);
        }

        public String getDomicile_address_region()
        {
            return domicileData.getDomicile_address_region();
        }

        public void setDomicile_address_region(String domicile_address_region)
        {
            domicileData.setDomicile_address_region(domicile_address_region);
        }

        public String getDomicile_address_state()
        {
            return domicileData.getDomicile_address_state();
        }

        public void setDomicile_address_state(String domicile_address_state)
        {
            domicileData.setDomicile_address_state(domicile_address_state);
        }

        public String getDomicile_address_poscode()
        {
            return domicileData.getDomicile_address_poscode();
        }

        public void setDomicile_address_poscode(String domicile_address_poscode)
        {
            domicileData.setDomicile_address_poscode(domicile_address_poscode);
        }

        public String getDomicile_address_country_code()
        {
            return domicileData.getDomicile_address_country_code();
        }

        public void setDomicile_address_country_code(String domicile_address_country_code)
        {
            domicileData.setDomicile_address_country_code(domicile_address_country_code);
        }

        public String getDomicile_phone_no()
        {
            return domicileData.getDomicile_phone_no();
        }

        public void setDomicile_phone_no(String domicile_phone_no)
        {
            domicileData.setDomicile_phone_no(domicile_phone_no);
        }

        public String getFrisk1()
        {
            return app.getFrisk1();
        }

        public void setFrisk1(String frisk1)
        {
            app.setFrisk1(frisk1);
        }

        public String getFrisk2()
        {
            return app.getFrisk2();
        }

        public void setFrisk2(String frisk2)
        {
            app.setFrisk2(frisk2);
        }

        public String getMparam1()
        {
            return app.getMparam1();
        }

        public void setMparam1(String mparam1)
        {
            app.setMparam1(mparam1);
        }

        public String getMparam2()
        {
            return app.getMparam2();
        }

        public void setMparam2(String mparam2)
        {
            app.setMparam2(mparam2);
        }

        public String getResponse_type()
        {
            return app.getResponse_type();
        }

        public void setResponse_type(String response_type)
        {
            app.setResponse_type(response_type);
        }



        public String getReturn_url()
        {
            return app.getReturn_url();
        }

        public void setReturn_url(String return_url)
        {
            app.setReturn_url(return_url);
        }

        public String getCustomer_ref()
        {
            return shopperData.getCustomer_ref();
        }

        public void setCustomer_ref(String customer_ref)
        {
            shopperData.setCustomer_ref(customer_ref);
        }

        public String getCustname()
        {
            return shopperData.getCustname();
        }

        public void setCustname(String custname)
        {
            shopperData.setCustname(custname);
        }

        public String getCustemail()
        {
            return shopperData.getCustemail();
        }

        public void setCustemail(String custemail)
        {
            shopperData.setCustemail(custemail);
        }

        public String getShopper_ip()
        {
            return shopperData.getShopper_ip();
        }

        public void setShopper_ip(String shopper_ip)
        {
            shopperData.setShopper_ip(shopper_ip);
        }

        public String getDescription()
        {
            return shopperData.getDescription();
        }

        public void setDescription(String description)
        {
            shopperData.setDescription(description);
        }

        public String getCardno()
        {
            return shopperData.getCardno();
        }

        public void setCardno(String cardno)
        {
            shopperData.setCardno(cardno);
        }

        public String getCardname()
        {
            return shopperData.getCardname();
        }

        public void setCardname(String cardname)
        {
            shopperData.setCardname(cardname);
        }

        public String getCardtype()
        {
            return Char.ToString(shopperData.getCardtype());
        }

        public void setCardtype(String cardtype)
        {

        }

        public String getExpirymonth()
        {
            return shopperData.getExpirymonth();
        }

        public void setExpirymonth(String expirymonth)
        {
            shopperData.setExpirymonth(expirymonth);
        }

        public String getExpiryyear()
        {
            return shopperData.getExpiryyear();
        }

        public void setExpiryyear(String expiryyear)
        {
            shopperData.setExpiryyear(expiryyear);
        }

        public String getCardcvc()
        {
            return shopperData.getCardcvc();
        }

        public void setCardcvc(String cardcvc)
        {
            shopperData.setCardcvc(cardcvc);
        }

        public String getCard_issuer_bank_country_code()
        {
            return shopperData.getCard_issuer_bank_country_code();
        }

        public void setCard_issuer_bank_country_code(String card_issuer_bank_country_code)
        {
            shopperData.setCard_issuer_bank_country_code(card_issuer_bank_country_code);
        }

        public String getPhone_no()
        {
            return shopperData.getPhone_no();
        }

        public void setPhone_no(String phone_no)
        {
            shopperData.setPhone_no(phone_no);
        }

        public String getBilling_address()
        {
            return billData.getBilling_address();
        }

        public void setBilling_address(String billing_address)
        {
            billData.setBilling_address(billing_address);
        }

        public String getBilling_address_city()
        {
            return billData.getBilling_address_city();
        }

        public void setBilling_address_city(String billing_address_city)
        {
            billData.setBilling_address_city(billing_address_city);
        }

        public String getBilling_address_region()
        {
            return billData.getBilling_address_region();
        }

        public void setBilling_address_region(String billing_address_region)
        {
            billData.setBilling_address_region(billing_address_region);
        }

        public String getBilling_address_state()
        {
            return billData.getBilling_address_state();
        }

        public void setBilling_address_state(String billing_address_state)
        {
            billData.setBilling_address_state(billing_address_state);
        }

        public String getBilling_address_poscode()
        {
            return billData.getBilling_address_poscode();
        }

        public void setBilling_address_poscode(String billing_address_poscode)
        {
            billData.setBilling_address_poscode(billing_address_poscode);
        }

        public String getBilling_address_country_code()
        {
            return billData.getBilling_address_country_code();
        }

        public void setBilling_address_country_code(String billing_address_country_code)
        {
            billData.setBilling_address_country_code(billing_address_country_code);
        }

        public String getReceiver_name_for_shipping()
        {
            return shippingdata.getReceiver_name_for_shipping();
        }

        public void setReceiver_name_for_shipping(String receiver_name_for_shipping)
        {
            shippingdata.setReceiver_name_for_shipping(receiver_name_for_shipping);
        }

        public String getShipping_address()
        {
            return shippingdata.getShipping_address();
        }

        public void setShipping_address(String shipping_address)
        {
            shippingdata.setShipping_address(shipping_address);
        }

        public String getShipping_address_city()
        {
            return shippingdata.getShipping_address_city();
        }

        public void setShipping_address_city(String shipping_address_city)
        {
            shippingdata.setShipping_address_city(shipping_address_city);
        }

        public String getShipping_address_region()
        {
            return shippingdata.getShipping_address_region();
        }

        public void setShipping_address_region(String shipping_address_region)
        {
            shippingdata.setShipping_address_region(shipping_address_region);
        }

        public String getShipping_address_state()
        {
            return shippingdata.getShipping_address_state();
        }

        public void setShipping_address_state(String shipping_address_state)
        {
            shippingdata.setShipping_address_state(shipping_address_state);
        }

        public String getShipping_address_poscode()
        {
            return shippingdata.getShipping_address_poscode();
        }

        public void setShipping_address_poscode(String shipping_address_poscode)
        {
            shippingdata.setShipping_address_poscode(shipping_address_poscode);
        }

        public String getShipping_address_country_code()
        {
            return shippingdata.getShipping_address_country_code();
        }

        public void setShipping_address_country_code(String shipping_address_country_code)
        {
            shippingdata.setShipping_address_country_code(shipping_address_country_code);
        }

        public String getShippingcost()
        {
            return shippingdata.getShippingcost();
        }

        public void setShippingcost(String shippingcost)
        {
            shippingdata.setShippingcost(shippingcost);
        }

        public String getMref1()
        {
            return itemData.getMref1();
        }

        public void setMref1(String mref1)
        {
            itemData.setMref1(mref1);
        }

        public String getMref2()
        {
            return itemData.getMref2();
        }

        public void setMref2(String mref2)
        {
            itemData.setMref2(mref2);
        }

        public String getMref3()
        {
            return itemData.getMref3();
        }

        public void setMref3(String mref3)
        {
            itemData.setMref3(mref3);
        }

        public String getMref4()
        {
            return itemData.getMref4();
        }

        public void setMref4(String mref4)
        {
            itemData.setMref4(mref4);
        }

        public String getMref5()
        {
            return itemData.getMref5();
        }

        public void setMref5(String mref5)
        {
            itemData.setMref5(mref5);
        }

        public String getMref6()
        {
            return itemData.getMref6();
        }

        public void setMref6(String mref6)
        {
            itemData.setMref6(mref6);
        }

        public String getMref7()
        {
            return itemData.getMref7();
        }

        public void setMref7(String mref7)
        {
            itemData.setMref7(mref7);
        }

        public String getMref8()
        {
            return itemData.getMref8();
        }

        public void setMref8(String mref8)
        {
            itemData.setMref8(mref8);
        }

        public String getMref9()
        {
            return itemData.getMref9();
        }

        public void setMref9(String mref9)
        {
            itemData.setMref9(mref9);
        }

        public String getMref10()
        {
            return itemData.getMref10();
        }

        public void setMref10(String mref10)
        {
            itemData.setMref10(mref10);
        }

        public String getPymt_ind()
        {
            return pymt_ind;
        }

        public void setPymt_ind(String pymt_ind)
        {
            this.pymt_ind = pymt_ind;
        }

        public String getPymt_criteria()
        {
            return pymt_criteria;
        }

        public void setPymt_criteria(String pymt_criteria)
        {
            this.pymt_criteria = pymt_criteria;
        }
    }
}
