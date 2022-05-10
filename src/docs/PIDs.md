---
layout: docs
title: Persistent identifiers (PIDs)
published: 2022-05-09
Author: Dominik Brilhaus <https://orcid.org/0000-0001-9021-3197>
add toc: true
add sidebar: sidebars\mainSidebar.md
Article Status: draft
To-Dos: 
    - write
---



<!-- 
# export all .md files in current dir to .docx via pandoc 
for f in *.md; do pandoc -s -o "${f%.md}.docx" "$f"; done
-->

# Persistent identifiers (PIDs)

<!-- TOC -->

- [What are PIDs?](#what-are-pids)
- [Globally unique and persistent](#globally-unique-and-persistent)
- [What can I reference with a PID? How do I assign a PID? And why do I benefit from PIDs?](#what-can-i-reference-with-a-pid-how-do-i-assign-a-pid-and-why-do-i-benefit-from-pids)
- [Common examples for PIDs](#common-examples-for-pids)
  - [People](#people)
  - [Digital objects and publications](#digital-objects-and-publications)
  - [Samples and Resources](#samples-and-resources)
  - [Institutions](#institutions)
- [How does DataPLANT support me in using PIDs?](#how-does-dataplant-support-me-in-using-pids)

<!-- /TOC -->

## What are PIDs?

Persistent identifiers (PIDs) &ndash; as the name suggests &ndash; enable to persistently identify a resource (an entity).
This may sound complicated, but consider a (common) daily life example for PIDs: the International Standard Book Number (ISBN). The 13-digit ISBN code allows to unambiguously identify a book without having to specify book author, title or any other detail. Just as the ISBN alone helps to find and order a book at a local retailer, PIDs enable to easily find different entities or resources relevant to (plant) sciences. This can include publications, methods, samples or other experimental materials, softwares and the datasets they produce or the researchers contributing to the earlier.

## Globally unique and persistent

Two major requirements of PIDs are the reason they contribute to virtually all aspects of [FAIR][KB-FAIR] data management. PIDs need to be **globally unique** and **persistent**, i.e. they stably resolve to identify the respective resource also in the (foreseeable) future. Global uniqueness is nowadays achieved technically through use of the internet. Put simply: no web address can be duplicated. However, it is good to know that standard URLs (uniform resource locators, "web addresses") cannot be considered PIDs. Sparing the technical details behind PIDs (see [PURLs] and [Handles]), consider the homepage of an institute where a publication was originally stored at the URL `https://plant-science-institute.com/research/publications/publication` and after homepage restructuring moved to `https://plant-science-institute.com/about/outputs/publication`. The earlier URL becomes a "dead link", impossible to be properly resolve and identify the linked publication, a phenomenon known as "link rot".
Although many PIDs resolve to a URL, taking the user to the proper location, they more importantly resolve to the content of the linked digital object (e.g. a dataset or publication). The example shows that the technical layer alone (global uniqueness through web addresses) is not enough to guarantee persistence and prevent "link rot". This is achieved socially through defined policies and institutions: PIDs are actively curated and managed through registration services overseeing that the linked digital object is properly located.

## What can I reference with a PID? How do I assign a PID? And why do I benefit from PIDs?

Although basically any imaginable &ndash; both analog and digital &ndash; entity can be assigned a PID, we mostly focus on PIDs that identify digital objects or resources. However these digital resources themselves maybe descriptors of analog entities such as items at museums, samples from a collection, artistic or musical outputs. The exact benefit and how a resource is assigned a PID depends on the context: what type of entity is referenced with a PID.

The two best known examples for PIDs used in science are **DOI** (Digital Object Identifier) and **ORCID** (Open Researcher and Contributor ID).
The most established use of DOIs is to identify publications. Similar to an ISBN for a book, a DOI alone suffices to persistently link and refer to a publication, without naming the title, authors or journal. Usually DOIs are not actively requested by standard users, e.g. the authors submitting a manuscript to a journal or data to a repository, but they are assigned during the publication process, e.g. by the journal or data repository acting as the PID registration service.
<!-- As scientists, we benefit from DOI-referenced publications by better findability and more concise referencing (see also [KB-DataPublication]) -->
An ORCID on the other hand needs to be requested (once) by a researcher. ORCIDs concisely identify researchers independent of identical names between multiple researchers or name changes (e.g. due to wedding). They can actively be curated, e.g. to link and present all publication or other digital outputs.

<!-- In summary, PIDs help making data FAIR. A dataset that is persistently linked via a PID will be findable and accesible and thereby  -->

## Common examples for PIDs

### People

- Open Researcher and Contributor ID (ORCID, <https://orcid.org/>)

### Digital objects and publications

- Digital Object Identifier (DOI, <https://www.doi.org>)
- ePIC consortium <https://www.pidconsortium.net>
- Pubmed ID (PMID, <https://pubmed.ncbi.nlm.nih.gov>)

### Samples and Resources

- Research Resource Identifiers (RRIDs) <http://scicrunch.org/resources>

### Institutions

- Research Organization Registry (ROR, <https://ror.org>)
- Global Research Identifier Database (GRID, <https://grid.ac>)

## How does DataPLANT support me in using PIDs?

The following table gives an overview about DataPLANT tools and services related to sharing data. Follow the link in the first column for details.

Name | Type | Tasks on metadata 
----------------|-----------|------------------ 
- invenio


<!-- Helpdesk Outro-->

Besides these technical solutions, DataPLANT supports you with community-engaged data stewardship. For further assistance, feel free to reach out via our [helpdesk](https://support.nfdi4plants.org) or by contacting us <a href="mailto:dataplant@uni-kl.de?subject=DataPLANT%20Data%20Sharing">directly</a>.

<!-- Knowledgebase Cross-references -->

1. [KB-FAIR]: Link to knowledgebase article "FAIR principles"
1. [KB-Metadata]: link to article metadata

<!-- Reference links -->
[DataHUB]: <https://git.nfdi4plants.org> "ARC DataHUB"
[ARC]: <https://github.com/nfdi4plants/ARC> "ARC specifications"

[PURLs]: https://en.wikipedia.org/wiki/Persistent_uniform_resource_locator
[Handles]: https://en.wikipedia.org/wiki/Handle_System

<!-- References -->

- https://www.doi.org/faq.html



<!-- - Globally unique: One URI should never refer to two different concepts at the same time, even ones that may seem equivalent.
- Persistent: A URI should continue to resolve for the forseeable future. The URI should survive between website re-engineering exercises, for example.
- Stable: A URI should never be re-used for different things between data releases, even if the original is deleted.
- Resolvable (dereferenceable): Simply, when a user clicks on a URI in their browser, we want them to be redirected to a suitable document. That doesn’t necessarily mean it should be capable of returning RDF content.

Source: https://www.ebi.ac.uk/rdf/documentation/good_practice_uri/ (16.02.2022) -->


<!-- 
### isn't this just a hyperlink / URL?

1. url = resolves to a location, PID = resolves to the content, e.g. a digital object, dataset, publication
2. PIDs are actively curated and managed
  - preventing link rot (https://en.wikipedia.org/wiki/Link_rot), i.e. broken or dead links
  - changed location of a resource
  - The persistence is not technically inherent, but socially implemented.

- globally unique -> solved technically through http / internet
    - without elaborating the details behind PURLs and handles, it is important to note that 
    - url = resolves to a location, PID = resolves to the content, e.g. a digital object, dataset, publication
  - persistent and stable (into foreseeable future) -> solved socially / policy / institutionally through registration services -->


<!-- Other daily example: 
- SWIFT-BIC (business identifier code) allows to identify financial institutions
- SWIFT (Society for Worldwide Interbank Financial Telecommunication) = registration authority for BIC 
- VIN (Vehicle identification number)
- Lot number
-->