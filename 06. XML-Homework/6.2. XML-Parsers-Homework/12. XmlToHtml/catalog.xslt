﻿<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes' />
  <xsl:template match="/">
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;</xsl:text>
    <html>
      <body>
        <h2>Music Catalog</h2>
        <table border="1">
          <tr bgcolor="green">
            <th align="left">Name</th>
            <th align="left">Artist</th>
            <th align="left">Year</th>
            <th align="left">Producer</th>
            <th align="left">Price</th>
          </tr>
          <xsl:for-each select="albums">
            <xsl:for-each select="album">
              <tr bgcolor ="lightgreen">
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="artist"/>
                </td>
                <td>
                  <xsl:value-of select="year"/>
                </td>
                <td>
                  <xsl:value-of select="producer"/>
                </td>
                <td>
                  <xsl:value-of select="price"/>
                </td>
              </tr>
            </xsl:for-each>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>