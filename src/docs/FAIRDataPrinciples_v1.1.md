---
layout: docs
title: FAIR Principles
published: 2022-05-09
Author: ?
add toc: true
add sidebar: sidebars\mainSidebar.md
Article Status: Publishable
---


# FAIR Principles
The [FAIR Principles](https://www.nature.com/articles/sdata201618) were published in 2016 to serve as guidelines for improving the **F**indability, **A**ccessibility, **I**nteroperability, and **R**eusability of scientific data. While researchers need to be able to find and understand published datasets, computers need to handle (big) data depending on the intended use case. Thus, the FAIR principles aim to improve the machine-readability of datasets for autonomous processing, while preserving human-readability.

Albeit data can only be FAIR when provided with (all necessary) metadata by the authors, researchers rely on infrastructures to set a framework for meeting the criteria. Hence, FAIR(ness) (simultaneously) addresses both stakeholders publishing data and those providing infrastructures, such as repositories.

The ultimate goal of FAIR (data) is to drive science and the production of new datasets, as it allows researchers to build on (already) existing comprehensively annotated studies. In plant biology, this, e.g., can accelerate the innovation process of generating new crop species that provide a higher nutritional content or show a superior heat tolerance, regarding global warming. Submitting your proteomics dataset for such a new species in a standardized file format to a repository, e.g. [PRIDE](https://www.ebi.ac.uk/pride/archive/), would be one implementation of the FAIR Principles, to give you an example for biology here. In the following we will give you a short overview and a more [detailed explanation](#Detailed-FAIR-principles) on the individual FAIR aspects.


### Findable
- [F1. (Meta)data are assigned a globally unique and persistent identifier](#<ins>**F1.-(Meta)data-are-assigned-a-globally-unique-and-persistent-identifier**)
- [F2. Data are described with rich metadata (defined by R1 below)](#<ins>**F2.-Data-are-described-with-rich-metadata-(defined-by-R1-below)**)
- [F3. Metadata clearly and explicitly include the identifier of the data they describe](#<ins>**F3.-Metadata-clearly-and-explicitly-include-the-identifier-of-the-data-they-describe**)
- [F4. (Meta)data are registered or indexed in a searchable resource](#<ins>**F4.-(Meta)data-are-registered-or-indexed-in-a-searchable-resource**)

### Accessible
- [A1. (Meta)data are retrievable by their identifier using a standardised communications protocol](#<ins>**A1.-(Meta)data-are-retrievable-by-their-identifier-using-a-standardised-communications-protocol**)
    - [A1.1 The protocol is open, free, and universally implementable](#<ins>**A1.1-The-protocol-is-open,-free,-and-universally-implementable**)
    - [A1.2 The protocol allows for an authentication and authorisation procedure, where necessary](#<ins>**A1.2-The-protocol-allows-for-an-authentication-and-authorisation-procedure,-where-necessary**)
- [A2. Metadata are accessible, even when the data are no longer available](#<ins>**A2.-Metadata-are-accessible,-even-when-the-data-are-no-longer-available**)

### Interoperable
- [I1. (Meta)data use a formal, accessible, shared, and broadly applicable language for knowledge representation](#<ins>**I1.-(Meta)data-use-a-formal,-accessible,-shared,-and-broadly-applicable-language-for-knowledge-representation**)
- [I2. (Meta)data use vocabularies that follow FAIR principles](#<ins>**I2.-(Meta)data-use-vocabularies-that-follow-FAIR-principles**)
- [I3. (Meta)data include qualified references to other (meta)data](#<ins>**I3.-(Meta)data-include-qualified-references-to-other-(meta)data**)


### Reusable
- [R1. (Meta)data are richly described with a plurality of accurate and relevant attributes](#<ins>**R1.-(Meta)data-are-richly-described-with-a-plurality-of-accurate-and-relevant-attributes**)
  - [R1.1. (Meta)data are released with a clear and accessible data usage license](#<ins>**R1.1.-(Meta)data-are-released-with-a-clear-and-accessible-data-usage-license**)
  - [R1.2. (Meta)data are associated with detailed provenance](#<ins>**R1.2.-(Meta)data-are-associated-with-detailed-provenance**)
  - [R1.3. (Meta)data meet domain-relevant community standards](#<ins>**R1.3.-(Meta)data-meet-domain-relevant-community-standards**)


![FAIRData](FAIR.jpg)

## Detailed FAIR Principles
### Findable
The first step in (re)using your data is to find them. Metadata and data should be easy to find for both humans and computers, including machine-readable metadata that are essential for automatic discovery of your datasets and services.

### <ins>**F1. (Meta)data are assigned a globally unique and persistent identifier**
A persistent identifier (PID) is a long-lasting reference, typically used in the context of digital resources accessible over the internet, in this case your dataset. Globally unique and persistent identifiers allow finding your data in the first place. Continuous availability of the digital object is guaranteed by registry providers, which maintain the link to the actual dataset.

A PID you have probably already heard of as most biological journals assign them to manuscripts, is the Digital Object Identifier ([DOI](https://www.doi.org/hb.html)). Your personal 16-digit ORCID (iD) or the accession number of your RNASeq dataset on GEO also represent examples for PIDs. An overview which scientific repositories assign which type of PID can be found at the registry of research data repositories ([re3data.org](https://www.re3data.org/)).

### <ins>**F2. Data are described with rich metadata (defined by R1 below)**
To enable (automatic) findability of your dataset, it is essential for humans and computers to understand its content. This is supported by comprehensive metadata in a standardized format about the dataset (how it was generated), its context (including associated data), or associated publications . This aspect goes hand in hand with making your data reusable and is therefore additionally addressed during metadata attributes (R1). As publisher of the data, you should always keep in mind that it is best to provide as much information as possible, as others will generally profit from more input. Repository providers should set the framework for this aspect by giving researchers the possibility to fully describe their datasets, e.g. with a submission form.

### <ins>**F3. Metadata clearly and explicitly include the identifier of the data they describe**
As explained above, your data need to be assigned with a globally unique and persistent identifier (F1). Accordingly, this identifier must be included in your metadata file to link the information to the corresponding data file. A requirement, which must be ensured by infrastructure providers. Even though your dataset might not have been published, and archived subsequently, the PID included in the metadata can link you as the responsible contact person for the dataset. Thereby, the PID can still help other researchers to find your data and you in increasing your reach.

### <ins>**F4. (Meta)data are registered or indexed in a searchable resource**
Repositories must ensure that metadata for a submitted dataset are filed in a machine-readable format to enable indexing. The indices of your metadata are used (by computers) to efficiently search and find datasets. Once again it needs to be highlighted, that you should equip your metadata with as many information as possible, as more input simplifies the searching process.

### Accessible
Once users find your data, they need to know how they can access it, possibly including authentication and authorization.

### <ins>**A1. (Meta)data are retrievable by their identifier using a standardised communications protocol**
Standardized communication protocols, in combination with persistent identifiers, can guarantee access to your datasets, as links are maintained by the identifier providers. Examples of such protocols are http(s) or ftp(s). Accordingly, the combination of protocol and PID could look like <ins>https://doi.org/10.1000/182</ins>. You should avoid protocols with poor documentation or elements that need human assistance, as these lead to hurdles in accessing data. For highly sensitive data it can be an option to provide an email or telephone number of a contact person, as fully mechanized protocols cannot guarantee secure access.

### <ins>**A1.1 The protocol is open, free, and universally implementable**
Infrastructure providers should use free (no-cost), open-source protocols. Thus, these protocols are globally implementable and can grant researchers around the globe access to the data, at least to the metadata. As researcher, you can maximize the reuse of your data if you share your data with repositories that follow these criteria. Avoid proprietary and non-standard protocols.

### <ins>**A1.2 The protocol allows for an authentication and authorisation procedure, where necessary**
At this point it is very important to differentiate between "accessible" and "open" data. The "A" in FAIR does not imply that you are required to grant free access for everyone to your data, but rather to specify conditions under which the data are accessible. Even protected data are FAIR, if requirements were defined on how the data can be retrieved. These must be processable automatically by a system, e.g. a repository, and can be especially necessary for sensitive data.

An example for this case is a private and thereby, non-visible repository on [GitLab]() *cross-reference*, accessible only to defined users. As owner of the GitLab repository, you can select these users and researchers simply identify using the GitLab sign-in. Accordingly, the mechanism to allow users to identify themselves, belongs to the responsibility of the infrastructure provider.

### <ins>**A2. Metadata are accessible, even when the data are no longer available**
Metadata and actual datasets should be stored in separate files. In this way, your metadata can and should persist even when the dataset was archived or is no longer supported (due to evolving technologies), as storing metadata is generally easier and cheaper. Researchers and infrastructure providers can thereby ensure that a link to responsible contact persons remains available and that researchers searching for the data do not waste time . This will also help you as the data provider to maintain your reach. 

### Interoperable
To make your data reusable it usually needs to be integrated with other data. In addition, the data need to interoperate with applications or workflows for analysis, storage, and processing.

### <ins>**I1. (Meta)data use a formal, accessible, shared, and broadly applicable language for knowledge representation**
Besides other researchers, with whom you want to discuss and exchange your (newest) discoveries, your data can be processed by machines. This should be possible without human assistance or any additional algorithms, tools, or mappings specifically developed for this use case. Interoperability typically means that each computer system at least has knowledge of the other system's data exchange formats. Hence, using a good data model, to describe and structure your (meta)data and using commonly used controlled vocabularies, [ontologies]() *cross-reference*, and thesauri, each with globally unique PIDs, strongly supports you in generating interoperable data that can be found automatically. This holds especially true for metadata, as they contextualize your dataset and in the ideal case avoid any kind of questions or confusion.

### <ins>**I2. (Meta)data use vocabularies that follow FAIR principles**
Ontologies and controlled vocabularies you use to describe your datasets need to be documented and resolvable using globally unique PIDs. These documentations include authors, definitions of terms and cross-references to other ontologies, amongst others. Additionally, the documentation needs to be accessible and findable by anyone who uses the dataset , e.g., by a URL included in your metadata.

### <ins>**I3. (Meta)data include qualified references to other (meta)data**
Datasets are not static since they can evolve through extension by additional data or analyses by new algorithms. In such cases you generate newer versions of your data, which need to be stated as such by qualified references. Qualified references are cross-references that explain their intent, meaning in our example that characterizing V1 as the previous version of V2 of your dataset is a much more qualified reference than simply describing the two versions as related. Correspondingly, you should provide as many meaningful links as possible, preferably via PIDs,  between datasets that build on other datasets, additional datasets needed to complete a dataset, or complementary information stored in a different dataset. 

### Reusable
The ultimate goal of FAIR is to optimise the reuse your data. To achieve this, metadata and data should be well-described so that they can be replicated and/or combined in different settings.

### <ins>**R1. (Meta)data are richly described with a plurality of accurate and relevant attributes**
Principle R1 is related to F2, but focuses on assisting humans and machines to decide if your data is actually useful in a particular context. This can be facilitated by giving as many standardized information on the context under which and how the data was generated, e.g. which specific strain was used or the parameters under which a mass spectrometer was run, but also "simple" information as the manufacturer of an incubator or sensor.
As author of your dataset you cannot expect other researchers to be familiar with your methods or domain. Therefore, you should be as generous as possible in providing metadata and even include information that seem irrelevant to you. As infrastructure provider you should give researchers the option to include a variety of metadata, including optional and free-text fields. Exemplary questions that need to be answered by the metadata are:

- Who created the data?
- When was the data created and/or published?
- How was the data generated?
- How was the data processed?
- Are there any limitations other users should be aware of?
- ...

### <ins>**R1.1. (Meta)data are released with a clear and accessible data usage license**
You should clearly describe the usage rights for your data and include it in your metadata, as ambiguity could severely limit its reuse. Hence, the conditions under which the data can be used should be clear to machines and humans and can, e.g., be represented in form of a license. For scientific data, [Creative Commons licenses](https://creativecommons.org/) are commonly used.

### <ins>**R1.2. (Meta)data are associated with detailed provenance**
Ultimately, this point means nothing more than "where does your (meta)data originate from?" This includes a human- and machine-readable description of persons who collected the data, the workflows used to generate your data, information on additional external data, but also different versions of the data, amongst others. This information must be linked via PIDs. Always keep in mind that other researchers want to be just as much acknowledged for their work as you.

### <ins>**R1.3. (Meta)data meet domain-relevant community standards**
Researchers find it easiest to reuse data, if they are familiar with the type of data, file formats (well-established and sustainable), how the (meta)data is organized, and if commonly used vocabularies and [ontologies]() *cross-reference* are integratedsed. 

FAIR data should at least meet minimal information standards, such as MIAPPE, MIAME, or MIAPE. Other community standards may be less formal, but nevertheless, publishing (meta)data in a manner that increases its use(ability) for the community is the primary objective of FAIRness. In this context, DataPLANT aims at supporting the plant biology community in producing FAIR data by providing a framework for their domain.

All of the above stated applies to data (or any digital object), metadata (information about that digital object), and infrastructure.


# Sources and further information
- [FAIR Principles](https://www.go-fair.org/fair-principles/)
- [The FAIR Guiding Principles for scientific data management and stewardship](https://www.nature.com/articles/sdata201618)


