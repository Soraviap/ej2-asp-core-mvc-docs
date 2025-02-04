---
layout: post
title: Getting Started with ##Platform_Name## Check Box Component
description: Checkout and learn about getting started with ##Platform_Name## Check Box component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple CheckBox in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add CheckBox to the project

We are going to render `CheckBox` component in **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/check-box/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/check-box/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![CheckBox Sample](./images/check-box.PNG)

## Run the application

After successful compilation of your application, simply press `F5` to run the application. The following example shows a default rendering of CheckBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/check-box/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/check-box/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the CheckBox state

The Essential JS 2 CheckBox contains 3 different states visually, they are:
* Checked
* Unchecked
* Indeterminate

The CheckBox [`checked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Checked) property is used to handle the checked and unchecked state. In checked state a tick mark will be added to the visualization of CheckBox.

### Indeterminate

The CheckBox indeterminate state can be set through [`indeterminate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Indeterminate) property. CheckBox indeterminate state masks the real value of CheckBox visually. The Checkbox cannot be changed to indeterminate state through the user interface, this state can be achieved only through the property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/state/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/check-box/state/state.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/state/razor %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/check-box/state/state.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

