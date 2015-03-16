<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes' />
  <xsl:template match="/">
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;</xsl:text>
    <html>
      <body>
        <h2>Students</h2>
        <table border="1">
          <tr bgcolor="#CCCCCC">
            <th align="left">Name</th>
            <th align="left">Gender</th>
            <th align="left">Birthdate</th>
            <th align="left">Phone Number</th>
            <th align="left">Email</th>
            <th align="left">University</th>
            <th align="left">Specialty</th>
            <th align="left">Faculty Number</th>
          </tr>
          <xsl:for-each select="students">
            <xsl:for-each select="student">
              <tr>
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="gender"/>
                </td>
                <td>
                  <xsl:value-of select="birthdate"/>
                </td>
                <td>
                  <xsl:value-of select="phone-number"/>
                </td>
                <td>
                  <xsl:value-of select="email"/>
                </td>
                <td>
                  <xsl:value-of select="university"/>
                </td>
                <td>
                  <xsl:value-of select="specialty"/>
                </td>
                <td>
                  <xsl:value-of select="faculty-number"/>
                </td>
              </tr>
            </xsl:for-each>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>