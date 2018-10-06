<?xml version="1.0" encoding="ISO-8859-1"?>


<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt"
	xmlns:b="http://schemas.openxmlformats.org/officeDocument/2006/bibliography">
	<xsl:output method="xml" encoding="us-ascii"/>



	<xsl:variable name="const_SepNames">
		<xsl:text>; </xsl:text>	
	</xsl:variable>

	<xsl:variable name="const_SepLastFirst">
		<xsl:text>, </xsl:text>	
	</xsl:variable>

	<xsl:variable name="const_Space">
		<xsl:text> </xsl:text>	
	</xsl:variable>

	<xsl:variable name="const_BracketOpen">
		<xsl:text>(</xsl:text>	
	</xsl:variable>

	<xsl:variable name="const_BracketClose">
		<xsl:text>)</xsl:text>	
	</xsl:variable>




	<xsl:template match="/">
		<xsl:choose>
			<xsl:when test="b:OfficeSortKey">
				<Key><xsl:text>Tag</xsl:text></Key>
			</xsl:when>

			<xsl:when test="b:Sources">
				<xsl:variable name="ListPopulatedWithMain">
					<xsl:call-template name="populateMain">
						<xsl:with-param name="Type">b:Sources</xsl:with-param>
					</xsl:call-template>
				</xsl:variable>
				
				<xsl:variable name="sList">
					<xsl:call-template name="sortedList">
						<xsl:with-param name="sourceRoot">
							<xsl:copy-of select="$ListPopulatedWithMain"/>
						</xsl:with-param>
						
					</xsl:call-template>
				</xsl:variable>

				
				
				<Sources xmlns="http://schemas.openxmlformats.org/officeDocument/2006/bibliography">
				<xsl:for-each select="msxsl:node-set($sList)/b:Sources/b:Source">
					<Source>
						<xsl:copy-of select="b:Tag"/>
						<Display>

							<xsl:variable name="display">

								<xsl:variable name="allAuthors">
									<xsl:if test="string-length(b:Author/b:Main/b:Corporate)=0">
										<xsl:for-each select="b:Author/b:Main">
									      <xsl:call-template name="formatPersonsAuthor"/>
										</xsl:for-each>
									</xsl:if>
									<xsl:if test="string-length(b:Author/b:Main/b:Corporate)>0">
										  <xsl:value-of select="b:Author/b:Main/b:Corporate"/>
									</xsl:if>										
								</xsl:variable>

								<xsl:value-of select="b:Tag"/>

								<xsl:if test="string-length($allAuthors) > 0">
									<xsl:value-of select="$const_SepLastFirst"/>
									<xsl:value-of select="$allAuthors"/>
								</xsl:if>

								<xsl:if test="string-length(b:Title) > 0">
									<xsl:value-of select="$const_SepNames"/>
									<xsl:value-of select="b:Title"/>
								</xsl:if>

								<xsl:if test="string-length(b:Year) > 0">
									<xsl:value-of select="$const_Space"/>
									<xsl:value-of select="$const_BracketOpen"/>
									<xsl:value-of select="b:Year"/>
									<xsl:value-of select="$const_BracketClose"/>
								</xsl:if>
							</xsl:variable>
							
							<xsl:choose>
								<xsl:when test="string-length(normalize-space($display))>0">
									<xsl:value-of select="$display"/>
								</xsl:when>
								<xsl:otherwise>
									<xsl:value-of select="b:Tag"/>
								</xsl:otherwise>
							</xsl:choose>
						</Display>
						<SimpleSearch>
							<xsl:call-template name="simplesearchSource"/>
						</SimpleSearch>
					</Source>
				</xsl:for-each>
				</Sources>
			</xsl:when>
		</xsl:choose>
	</xsl:template>

	
	<xsl:template name="sortedList">
		<xsl:param name="sourceRoot"/>
		
		<xsl:apply-templates select="msxsl:node-set($sourceRoot)/*">
			<xsl:sort select="b:Tag"/>
		</xsl:apply-templates>
		
	</xsl:template>


	<xsl:template match="*">
		<xsl:element name="{name()}" namespace="{namespace-uri()}">
			<xsl:for-each select="@*">
				<xsl:attribute name="{name()}" namespace="{namespace-uri()}">
					<xsl:value-of select="." />
				</xsl:attribute>
			</xsl:for-each>
			<xsl:apply-templates>		
				<xsl:sort select="b:Tag" />
			</xsl:apply-templates>
		</xsl:element>
	</xsl:template>

	<xsl:template match="text()">
		<xsl:value-of select="." />
	</xsl:template>
	
	<xsl:template name="populateMain">
		<xsl:param name="Type"/>
		
		<xsl:element name="{$Type}">
			
			<xsl:for-each select="/*[$Type]/b:Source">
				
				<xsl:variable name="MostImportantAuthorLocalName">
					
					<xsl:call-template name="MainContributors"/>
				</xsl:variable>
				<xsl:element name="{'b:Source'}">
          
          <b:Title>
            
            <xsl:if test="string-length(b:Title)>0">
              <xsl:value-of select="b:Title"/>
            </xsl:if>
            
            <xsl:if test="string-length(b:Title)=0">
              <xsl:choose>
                <xsl:when test="b:SourceType='Book' or
                                b:SourceType='JournalArticle' or
                                b:SourceType='ConferenceProceedings' or
                                b:SourceType='Report' or
                                b:SourceType='Performance' or
                                b:SourceType='Film' or
                                b:SourceType='Patent' or
                                b:SourceType='Case'">

                  <xsl:value-of select="b:ShortTitle"/>
                </xsl:when>

                <xsl:when test="b:SourceType='BookSection'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  <xsl:variable name="bookTitle" select="b:BookTitle"/>

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    <xsl:when test="string-length($bookTitle)>0">
                      <xsl:value-of select="$bookTitle"/>
                    </xsl:when>
                  </xsl:choose>

                </xsl:when>

                <xsl:when test="b:SourceType='ArticleInAPeriodical'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  <xsl:variable name="periodicalTitle" select="b:PeriodicalTitle"/>

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    <xsl:when test="string-length($periodicalTitle)>0">
                      <xsl:value-of select="$periodicalTitle"/>
                    </xsl:when>
                  </xsl:choose>
                </xsl:when>

                <xsl:when test="b:SourceType='InternetSite' or
                                b:SourceType='DocumentFromInternetSite'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  <xsl:variable name="internetSiteTitle" select="b:InternetSiteTitle"/>

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    <xsl:when test="string-length($internetSiteTitle)>0">
                      <xsl:value-of select="$internetSiteTitle"/>
                    </xsl:when>
                  </xsl:choose>
                </xsl:when>

                <xsl:when test="b:SourceType='ElectronicSource' or
                                b:SourceType='Art' or
                                b:SourceType='Misc'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  <xsl:variable name="publicationTitle" select="b:PublicationTitle"/>

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    <xsl:when test="string-length($publicationTitle)>0">
                      <xsl:value-of select="$publicationTitle"/>
                    </xsl:when>
                  </xsl:choose>
                </xsl:when>

                <xsl:when test="b:SourceType='SoundRecording'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  <xsl:variable name="albumTitle" select="b:AlbumTitle"/>

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    <xsl:when test="string-length($albumTitle)>0">
                      <xsl:value-of select="$albumTitle"/>
                    </xsl:when>
                  </xsl:choose>
                </xsl:when>

                <xsl:when test="b:SourceType='Interview'">
                  <xsl:variable name="shortTitle" select="b:ShortTitle"/>
                  
                  <xsl:variable name="broadcastTitle" select="b:BroadcastTitle"/>
                  

                  <xsl:choose>
                    <xsl:when test="string-length($shortTitle)>0">
                      <xsl:value-of select="$shortTitle"/>
                    </xsl:when>
                    
                    <xsl:when test="string-length($broadcastTitle)>0">
                      <xsl:value-of select="$broadcastTitle"/>
                    </xsl:when>
                    
                  </xsl:choose>
                </xsl:when>

              </xsl:choose>
            </xsl:if>
          </b:Title>
          
					<b:Author>
						
						<b:Main>
							<xsl:if test="string-length(./b:Author/*[local-name()=$MostImportantAuthorLocalName]/b:Corporate)=0">
								<b:NameList>
									<xsl:for-each select="./b:Author/*[local-name()=$MostImportantAuthorLocalName]/b:NameList/b:Person">
										<b:Person>
											
											<b:Last>
												<xsl:value-of select="./b:Last"/>
											</b:Last>
											<b:First>
												<xsl:value-of select="./b:First"/>
											</b:First>
											<b:Middle>
												<xsl:value-of select="./b:Middle"/>
											</b:Middle>
										</b:Person>
									</xsl:for-each>
								</b:NameList>
							</xsl:if>
							<xsl:if test="string-length(./b:Author/*[local-name()=$MostImportantAuthorLocalName]/b:Corporate)>0">
								<b:Corporate>
								  <xsl:value-of select="./b:Author/*[local-name()=$MostImportantAuthorLocalName]/b:Corporate"/>
								</b:Corporate>
							</xsl:if>
						</b:Main>
						<xsl:for-each select="./b:Author/*">
							
							<xsl:if test="name()!='b:Main'">
								<xsl:element name="{name()}" namespace="{namespace-uri()}">
									<xsl:call-template name="copyNameNodes"/>
									
								</xsl:element>
							</xsl:if>
						</xsl:for-each>
					</b:Author>
					<xsl:for-each select="*">
						
            <xsl:if test="name()!='b:Author' and name()!='b:Title'">
              <xsl:element name="{name()}" namespace="{namespace-uri()}">
								<xsl:call-template name="copyNodes"/>
								
							</xsl:element>
						</xsl:if>
					</xsl:for-each>
				</xsl:element>
			</xsl:for-each>
			<xsl:for-each select="/*[$Type]/*">
				
				<xsl:if test="local-name()!='Source'">
					<xsl:call-template name="copyTrees"/>
				</xsl:if>
			</xsl:for-each>
		</xsl:element>
	</xsl:template>
	
	
	
	<xsl:template name="MainContributors">
		<xsl:param name="SourceRoot"/>
		<xsl:choose>
			<xsl:when test="./b:SourceType='Book'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='BookSection'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:BookAuthor)>0">BookAuthor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='JournalArticle'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='ArticleInAPeriodical'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='ConferenceProceedings'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Report'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='SoundRecording'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Performer)>0">Performer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Artist)>0">Artist</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Composer)>0">Composer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Conductor)>0">Conductor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Performance'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Writer)>0">Writer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Performer)>0">Performer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Director)>0">Director</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Art'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Artist)>0">Artist</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='DocumentFromInternetSite'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='InternetSite'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Film'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Writer)>0">Writer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Performer)>0">Performer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Director)>0">Director</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Interview'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Interviewee)>0">Interviewee</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Interviewer)>0">Interviewer</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Compiler)>0">Compiler</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Patent'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Inventor)>0">Inventor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='ElectronicSource'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:ProducerName)>0">ProducerName</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Case'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Counsel)>0">Counsel</xsl:when>
				</xsl:choose>
			</xsl:when>

			<xsl:when test="./b:SourceType='Misc'">
				<xsl:choose>
					<xsl:when test="string-length(./b:Author/b:Author)>0">Author</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Editor)>0">Editor</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Translator)>0">Translator</xsl:when>
					<xsl:when test="string-length(./b:Author/b:Compiler)>0">Compiler</xsl:when>
				</xsl:choose>
			</xsl:when>
		</xsl:choose>
	</xsl:template>

	<xsl:template name="copyNameNodes">
		<xsl:if test="string-length(b:Corporate)=0">
			<b:NameList>
				<xsl:for-each select="b:NameList/b:Person">
					
					<b:Person>
						
						<xsl:if test="string-length(./b:Last)>0">
							
							<b:Last>
								<xsl:value-of select="./b:Last"/>
							</b:Last>
						</xsl:if>
						<xsl:if test="string-length(./b:First)>0">
							<b:First>
								<xsl:value-of select="./b:First"/>
							</b:First>
						</xsl:if>
						<xsl:if test="string-length(./b:Middle)">
							<b:Middle>
								<xsl:value-of select="./b:Middle"/>
							</b:Middle>
						</xsl:if>
					</b:Person>
				</xsl:for-each>
			</b:NameList>
		</xsl:if>
		<xsl:if test="string-length(b:Corporate)>0">
			<b:Corporate>
			  <xsl:value-of select="b:Corporate"/>
			</b:Corporate>
		</xsl:if>
	</xsl:template>


	<xsl:template name="copyNodes">
		<xsl:value-of select="."/>
	</xsl:template>


	<xsl:template name="copyTrees">
		<xsl:copy-of select ='.'/>
	</xsl:template>

	<xsl:template name="simplesearchField">
		<xsl:choose>
			<xsl:when test="local-name()='Guid'"/>
			<xsl:when test="local-name()='RefOrder'"/>
			<xsl:when test="local-name()='SourceType'"/>
			<xsl:otherwise>
				<xsl:value-of select="." /><xsl:text> </xsl:text>
			</xsl:otherwise>
		</xsl:choose>

		<xsl:for-each select="*">
				<xsl:call-template name="simplesearchField"/>
		</xsl:for-each>
	</xsl:template>

	<xsl:template name="simplesearchSource">
		<xsl:for-each select="*">
			<xsl:call-template name="simplesearchField"/>
		</xsl:for-each>
	</xsl:template>

  <xsl:template name="formatIntervieweeLfmSku">
    <xsl:for-each select="b:Author/b:Interviewee">
      <xsl:call-template name="formatPersonsAuthor"/>
    </xsl:for-each>
  </xsl:template>

  <xsl:template name="formatInterviewerLfmSku">
    <xsl:for-each select="b:Author/b:Interviewer">
      <xsl:call-template name="formatPersonsAuthor"/>
    </xsl:for-each>
  </xsl:template>

  <xsl:template name="formatPersonsAuthor">
	<xsl:if test="string-length(b:Corporate)=0">
		<xsl:for-each select="b:NameList/b:Person">
		  <xsl:if test="6 >= position()">
			<xsl:call-template name="formatMainAuthor"/>
		  </xsl:if>
		  <xsl:call-template name="formatPersonSeperatorMain"/>
		</xsl:for-each>
	</xsl:if>
	<xsl:if test="string-length(b:Corporate)>0">
	  <xsl:value-of select="b:Corporate"/>
	</xsl:if>
  </xsl:template>

  <xsl:template name="formatMainAuthor">
    <xsl:call-template name="formatNameCore">
      <xsl:with-param name="FML">
        <xsl:call-template name="templ_prop_Authors_FML"/>
      </xsl:with-param>
      <xsl:with-param name="FM">
        <xsl:call-template name="templ_prop_Authors_FM"/>
      </xsl:with-param>
      <xsl:with-param name="ML">
        <xsl:call-template name="templ_prop_Authors_ML"/>
      </xsl:with-param>
      <xsl:with-param name="FL">
        <xsl:call-template name="templ_prop_Authors_FL"/>
      </xsl:with-param>
      <xsl:with-param name="upperLast">no</xsl:with-param>
      <xsl:with-param name="withDot">yes</xsl:with-param>

    </xsl:call-template>
  </xsl:template>

  <xsl:template name="formatPersonSeperatorMain">
    <xsl:param name="isLast"/>

    <xsl:choose>
      <xsl:when test="6 >= count(../b:Person) and position() = count(../b:Person) - 1">
        <xsl:call-template name="templ_prop_AuthorsSeparator"/>
        <xsl:if test="string-length($isLast)=0 or $isLast=true()">
          <xsl:call-template name="templ_prop_Space"/>
        </xsl:if>
      </xsl:when>
      <xsl:when test="6 > position() and position() != count(../b:Person)">
        <xsl:call-template name="templ_prop_AuthorsSeparator"/>
      </xsl:when>
      <xsl:when test="count(../b:Person) > 6 and position() = count(../b:Person)">
        <xsl:call-template name="templ_prop_AuthorsSeparator"/>
        <xsl:call-template name="templ_str_AndOthersUnCap"/>
      </xsl:when>
      <xsl:when test="position()>6">
      </xsl:when>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="formatNameCore">
    <xsl:param name="FML"/>
    <xsl:param name="FM"/>
    <xsl:param name="ML"/>
    <xsl:param name="FL"/>
    <xsl:param name="upperLast"/>
    <xsl:param name="withDot"/>

    <xsl:variable name="first">
      <xsl:call-template name="handleSpaces">
        <xsl:with-param name="field" select="b:First"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="middle">
      <xsl:call-template name="handleSpaces">
        <xsl:with-param name="field" select="b:Middle"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="last">
      <xsl:call-template name="handleSpaces">
        <xsl:with-param name="field" select="b:Last"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="format">
      <xsl:choose>
        <xsl:when test="string-length($first) = 0 and string-length($middle) = 0 and string-length($last) = 0 ">
        </xsl:when>
        <xsl:when test="string-length($first) = 0 and string-length($middle) = 0 and string-length($last) != 0 ">
          <xsl:text>%L</xsl:text>
        </xsl:when>
        <xsl:when test="string-length($first) = 0 and string-length($middle) != 0 and string-length($last) = 0 ">
          <xsl:text>%M</xsl:text>
        </xsl:when>
        <xsl:when test="string-length($first) = 0 and string-length($middle) != 0 and string-length($last) != 0 ">
          <xsl:value-of select="$ML"/>
        </xsl:when>
        <xsl:when test="string-length($first) != 0 and string-length($middle) = 0 and string-length($last) = 0 ">
          <xsl:text>%F</xsl:text>
        </xsl:when>
        <xsl:when test="string-length($first) != 0 and string-length($middle) = 0 and string-length($last) != 0 ">
          <xsl:value-of select="$FL"/>
        </xsl:when>
        <xsl:when test="string-length($first) != 0 and string-length($middle) != 0 and string-length($last) = 0 ">
          <xsl:value-of select="$FM"/>
        </xsl:when>
        <xsl:when test="string-length($first) != 0 and string-length($middle) != 0 and string-length($last) != 0 ">
          <xsl:value-of select="$FML"/>
        </xsl:when>
      </xsl:choose>
    </xsl:variable>

    <xsl:call-template name="StringFormatName">
      <xsl:with-param name="format" select="$format"/>
      <xsl:with-param name="upperLast" select="$upperLast"/>
      <xsl:with-param name="withDot" select="$withDot"/>
    </xsl:call-template>

  </xsl:template>

  <xsl:template name="StringFormatName">
    <xsl:param name="format" />
    <xsl:param name="withDot" />
    <xsl:param name="upperLast"/>

    <xsl:variable name="prop_EndChars">
      <xsl:call-template name="templ_prop_EndChars"/>
    </xsl:variable>

    <xsl:choose>
      <xsl:when test="$format = ''"></xsl:when>
      <xsl:when test="substring($format, 1, 2) = '%%'">
        <xsl:text>%</xsl:text>
        <xsl:call-template name="StringFormatName">
          <xsl:with-param name="format" select="substring($format, 3)" />
          <xsl:with-param name="withDot" select="$withDot" />
          <xsl:with-param name="upperLast" select="$upperLast" />
        </xsl:call-template>

        <xsl:if test="string-length($format)=2 and withDot = 'yes' and not(contains($prop_EndChars, '%'))">
          <xsl:call-template name="templ_prop_Dot"/>
        </xsl:if>
      </xsl:when>
      <xsl:when test="substring($format, 1, 1) = '%'">
        <xsl:variable name="what" select="substring($format, 2, 1)" />

        <xsl:choose>
          <xsl:when test="(what = 'l' or what = 'L') and upperLast = 'yes'">
            <span style='text-transform: uppercase;'>
              <xsl:call-template name="formatNameOneItem">
                <xsl:with-param name="format" select="$what"/>
              </xsl:call-template>
            </span>
          </xsl:when>
          <xsl:otherwise>
            <xsl:call-template name="formatNameOneItem">
              <xsl:with-param name="format" select="$what"/>
            </xsl:call-template>
          </xsl:otherwise>
        </xsl:choose>
        <xsl:call-template name="StringFormatName">
          <xsl:with-param name="format" select="substring($format, 3)" />
          <xsl:with-param name="withDot" select="$withDot" />
          <xsl:with-param name="upperLast" select="$upperLast" />
        </xsl:call-template>
        <xsl:if test="string-length($format)=2 and withDot='yes'">
          <xsl:variable name="temp2">
            <xsl:call-template name="handleSpaces">
              <xsl:with-param name="field">
                <xsl:call-template name="formatNameOneItem">
                  <xsl:with-param name="format" select="$what"/>
                </xsl:call-template>
              </xsl:with-param>
            </xsl:call-template>
          </xsl:variable>
          <xsl:variable name="lastChar">
            <xsl:value-of select="substring($temp2, string-length($temp2))"/>
          </xsl:variable>
          <xsl:if test="not(contains($prop_EndChars, $lastChar))">
            <xsl:call-template name="templ_prop_Dot"/>
          </xsl:if>
        </xsl:if>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="substring($format, 1, 1)" />
        <xsl:call-template name="StringFormatName">
          <xsl:with-param name="format" select="substring($format, 2)" />
          <xsl:with-param name="withDot" select="$withDot" />
          <xsl:with-param name="upperLast" select="$upperLast" />
        </xsl:call-template>
        <xsl:if test="string-length($format)=1">
          <xsl:if test="withDot = 'yes' and not(contains($prop_EndChars, $format))">
            <xsl:call-template name="templ_prop_Dot"/>
          </xsl:if>
        </xsl:if>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="formatNameOneItem">
    <xsl:param name="format"/>

    <xsl:choose>
      <xsl:when test="$format = 'F'">
        <xsl:value-of select="b:First"/>
      </xsl:when>
      <xsl:when test="$format = 'L'">
        <xsl:value-of select="b:Last"/>
      </xsl:when>
      <xsl:when test="$format = 'M'">
        <xsl:value-of select="b:Middle"/>
      </xsl:when>
      <xsl:when test="$format = 'f'">
        <xsl:call-template name="formatNameInitial">
          <xsl:with-param name="name" select="b:First"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:when test="$format = 'm'">
        <xsl:call-template name="formatNameInitial">
          <xsl:with-param name="name" select="b:Middle"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:when test="$format = 'l'">
        <xsl:call-template name="formatNameInitial">
          <xsl:with-param name="name" select="b:Last"/>
        </xsl:call-template>
      </xsl:when>
    </xsl:choose>

  </xsl:template>

  <xsl:template name="formatNameInitial">
    <xsl:param name="name"/>
    <xsl:variable name="temp">
      <xsl:call-template name="handleSpaces">
        <xsl:with-param name="field" select="$name"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="prop_APA_Hyphens">
      <xsl:call-template name="templ_prop_Hyphens"/>
    </xsl:variable>

    <xsl:if test="string-length($temp)>0">

      <xsl:variable name="tempWithoutSpaces">
        <xsl:value-of select="translate($temp, '&#32;&#160;', '')"/>
        
      </xsl:variable>

      <xsl:if test="not(contains($prop_APA_Hyphens, substring($tempWithoutSpaces, 1, 1)))">
        <xsl:value-of select="substring($tempWithoutSpaces, 1, 1)"/>
        <xsl:call-template name="templ_prop_DotInitial"/>
      </xsl:if>

      <xsl:call-template name="handleHyphens">
        <xsl:with-param name="name" select="$tempWithoutSpaces"/>
      </xsl:call-template>
    </xsl:if>
  </xsl:template>

  <xsl:template name="handleHyphens">
    <xsl:param name="name"/>

    <xsl:variable name="prop_APA_Hyphens">
      <xsl:call-template name="templ_prop_Hyphens"/>
    </xsl:variable>

    <xsl:if test="string-length($name)>=2">
      <xsl:choose>
        <xsl:when test="contains($prop_APA_Hyphens, substring($name, 1, 1))">
          <xsl:value-of select="substring($name, 1, 2)"/>
          <xsl:call-template name="templ_prop_DotInitial"/>

          <xsl:call-template name="handleHyphens">
            <xsl:with-param name="name" select="substring($name, 3)"/>
          </xsl:call-template>
        </xsl:when>

        <xsl:otherwise>
          <xsl:call-template name="handleHyphens">
            <xsl:with-param name="name" select="substring($name, 2)"/>
          </xsl:call-template>
        </xsl:otherwise>
      </xsl:choose>

    </xsl:if>

  </xsl:template>

  <xsl:template name="handleSpaces">
    <xsl:param name="field"/>

    <xsl:variable name="prop_NormalizeSpace">
      <xsl:call-template name="templ_prop_NormalizeSpace"/>
    </xsl:variable>

    <xsl:choose>
      <xsl:when test="$prop_NormalizeSpace='yes'">
        <xsl:value-of select="normalize-space($field)"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$field"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="localLCID">
    <xsl:value-of select="/*/b:Locals/b:DefaultLCID"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_NormalizeSpace" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:text>no</xsl:text>
    
  </xsl:template>

  
  <xsl:template name="templ_prop_AuthorsSeparator" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:AuthorsSeparator"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Space" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:Space"/>
  </xsl:template>

  
  <xsl:template name="templ_str_AndOthersUnCap" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:Strings/b:AndOthersUnCap"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_EndChars" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:EndChars"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Dot" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:Dot"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Authors_FML" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:Authors/b:FML"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Authors_FM" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:Authors/b:FM"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Authors_ML" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:Authors/b:ML"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Authors_FL" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:Authors/b:FL"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_Hyphens" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:Hyphens"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_DotInitial" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:DotInitial"/>
  </xsl:template>


</xsl:stylesheet>

